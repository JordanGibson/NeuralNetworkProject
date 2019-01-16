using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML_Library;
using SandboxUI.ProjectHelper;
using System.Threading;
using System.Diagnostics;
using System.IO;
using SandboxUI.Dialogs;
using NHotkey.WindowsForms;
using NHotkey;
using System.Runtime.InteropServices;

namespace SandboxUI.Forms
{
    public partial class BaseSolutionForm : Form
    {
        protected CancellationTokenSource cancellationTokenSource;

        protected NeuralNetwork Network;
        protected Project Project;
        protected ProjectSettings projectSettings;
        
        protected double[][] Inputs;
        protected double[][] ExpectedOutputs;
        protected int TrainedCount;
        protected int LastTrainedCount = 0;
        protected string NetworkArchitectureToString { get { return Network.InputCount + " - " + string.Join(" - ", Network.Structure.Select(l => l.NodeCount)); } }
        protected string NetworkLearningRatesToString { get { return Network.Structure.All(o => o.LearningRate == Network.Structure[0].LearningRate) ? Network.Structure[0].LearningRate.ToString() : string.Join(" - ", Network.LearningRates); } }
        protected string NetworkActivationMethodsToString { get { return Network.Structure.All(o => o.ActivationMethod == Network.Structure[0].ActivationMethod) ? Network.Structure[0].ActivationMethod.ToString() : string.Join(" - ", Network.ActivationMethods); } }

        public bool isTrainingDataLoaded { get { return Inputs != null && ExpectedOutputs != null; } }


        public BaseSolutionForm()
        {
            InitializeComponent();
        }

        public BaseSolutionForm(Project project)
        {
            InitializeComponent();

            cancellationTokenSource = new CancellationTokenSource();
            projectSettings = ProjectSettings.GetSettings(project);
            lblWindowTitle.Text = projectSettings.Name;
            HotkeyManager.Current.AddOrReplace("Magnifier", Keys.Control, Form_ControlKeyPressed);
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private async void Form_ControlKeyPressed(object sender, HotkeyEventArgs e)
        {
            if (Process.GetProcessesByName("magnify").Length != 0)
            {
                Process.GetProcessesByName("magnify").First().Kill();
            }
            else
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    FileName = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\SandboxUI\Resources\Magnify.exe",
                    UseShellExecute = true,
                    Arguments = "/lens",
                    Verb = "runas"
                };
                p.Start();
            }
            e.Handled = true;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizeWindow_Click(object sender, EventArgs e)
        {
            ToggleWindowState();
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlWindowBar_DoubleClick(object sender, EventArgs e)
        {
            ToggleWindowState();
        }

        private void ToggleWindowState()
        {
            WindowState = WindowState == FormWindowState.Maximized ?
                 FormWindowState.Normal :
                 FormWindowState.Maximized;
        }

        protected void UpdateUIStatus()
        {
            bool isNetworkLoaded = Network != null;
            lblActivationMethod.Enabled = isNetworkLoaded;
            lblLearningRate.Enabled = isNetworkLoaded;
            btnEditNetwork.Enabled = isNetworkLoaded;
            btnClearNetwork.Enabled = isNetworkLoaded;
            pnlNetworkTraining.Enabled = isNetworkLoaded;
            btnSaveNetwork.Enabled = isNetworkLoaded;
            btnNewNetwork.Enabled = !isNetworkLoaded;
            btnLoadNetwork.Enabled = !isNetworkLoaded;

            if (isNetworkLoaded)
            {
                if(Network.Structure.All(o => o.ActivationMethod == Network.Structure[0].ActivationMethod))
                {
                    lblActivationMethod.Text = "Activation Method: " + Network.Structure[0].ActivationMethod.ToString();
                    lblActivationMethod.MouseEnter -= clickableLabels_MouseEnter;
                    lblActivationMethod.MouseLeave -= clickableLabels_MouseLeave;
                    lblActivationMethod.Click -= lblActivationMethod_Click;
                }
                else
                {
                    lblActivationMethod.Text = "Show Activation Methods";
                    lblActivationMethod.MouseEnter += clickableLabels_MouseEnter;
                    lblActivationMethod.MouseLeave += clickableLabels_MouseLeave;
                    lblActivationMethod.Click += lblActivationMethod_Click;
                }
                if (Network.Structure.All(o => o.LearningRate == Network.Structure[0].LearningRate))
                {
                    lblLearningRate.Text = "Learning Rate: "+ Network.Structure[0].LearningRate.ToString();
                    lblLearningRate.MouseEnter -= clickableLabels_MouseEnter;
                    lblLearningRate.MouseLeave -= clickableLabels_MouseLeave;
                    lblLearningRate.Click -= lblLearningRate_Click;
                }
                else
                {
                    lblLearningRate.Text = "Show Learning Rates";
                    lblLearningRate.MouseEnter += clickableLabels_MouseEnter;
                    lblLearningRate.MouseLeave += clickableLabels_MouseLeave;
                    lblLearningRate.Click += lblLearningRate_Click;
                }
                lblNetworkStructure.Text = "Structure: " + NetworkArchitectureToString;
                lblCurrentError.Text = Network.CurrentError == double.PositiveInfinity ? "Current Error: N/A" : "Current Error: " + Network.CurrentError;
            }
            else
            {
                lblLearningRate.Text = "Show Learning Rates";
                lblActivationMethod.Text = "Show Activation Methods";
                lblNetworkStructure.Text = "Structure: N/A";
                lblCurrentError.Text = "Current Error: N/A";
                lblTrainedCount.Text = "Trained Count: N/A";
                lblLastTrainedCount.Text = "Last Trained Count: N/A";
                pbxVisualRepresentation.Image = null;
            }
            AdditionalUIStatusUpdate();
        }

        protected virtual void AdditionalUIStatusUpdate()
        {

        }

        protected void ToggleNetworkTraining(bool enabled)
        {
            pnlNetworkConfiguration.Invoke(new Action(() => {
                pnlNetworkConfiguration.Enabled = !enabled;
                pnlNetworkTraining.Enabled = !enabled;
                pnlTrainingStatus.Visible = enabled;
                pgbTrainingProgress.Value = 0;
            }));
        }

        private void btnNewNetwork_Click(object sender, EventArgs e)
        {
            NewNetworkDialog newNetworkDialog = new NewNetworkDialog(projectSettings);
            Network = newNetworkDialog.ShowDialog();
            UpdateUIStatus();
        }

        private void btnEditNetwork_Click(object sender, EventArgs e)
        {
            EditNetworkDialog editNetworkDialog = new EditNetworkDialog(Network, projectSettings);
            Network = editNetworkDialog.ShowDialog();
            UpdateUIStatus();
        }

        private void btnClearNetwork_Click(object sender, EventArgs e)
        {
            Network = null;
            UpdateUIStatus();
        }

        private void clickableLabels_MouseEnter(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(100, 20, 20);
            Cursor = Cursors.Hand;
        }

        private void clickableLabels_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.White;
            Cursor = Cursors.Default;

        }

        private void lblLearningRate_Click(object sender, EventArgs e)
        {
            string message = string.Join(" - ", Network.LearningRates);
            DarkMessageBox darkMessageBox = new DarkMessageBox();
            darkMessageBox.ShowDialog(message, "Learning Rates");
        }

        private void lblActivationMethod_Click(object sender, EventArgs e)
        {
            string message = string.Join(" - ", Network.ActivationMethods);
            DarkMessageBox darkMessageBox = new DarkMessageBox();
            darkMessageBox.ShowDialog(message, "Learning Rates");
        }

        private async void btnTrain500_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Train(500, cancellationTokenSource.Token));
        }

        protected virtual void Train(int iterations, CancellationToken cancellationToken)
        {
            var indexList = Enumerable.Range(0, iterations).OrderBy(o => Utility.NextDouble()).ToList();
            Inputs = indexList.Select(o => Inputs[o]).ToArray();
            ExpectedOutputs = indexList.Select(o => ExpectedOutputs[o]).ToArray();

            ToggleNetworkTraining(true);
            Invoke(new Action(() => pgbTrainingProgress.Maximum = iterations));
            Stopwatch stopwatch = Stopwatch.StartNew();

            Progress<int> progress = new Progress<int>();
            long ticks = 0;
            progress.ProgressChanged += (sender, e) => {
                if(e % 5 == 0)
                    ticks = (long)((double)stopwatch.Elapsed.Ticks / e * (iterations - e));
                UpdateTrainingProgress(e, iterations, ticks);
            };

            Network.Train(Inputs, ExpectedOutputs, progress, cancellationToken);

            Inputs = null; ExpectedOutputs = null;
            LastTrainedCount = iterations;
            TrainedCount += iterations;

            UpdateVisualRepresentation();
            Invoke(new Action(() =>
            {
                lblTrainedCount.Text = string.Format("Trained Count: {0}", TrainedCount);
                lblLastTrainedCount.Text = string.Format("Last Trained Count: {0}", LastTrainedCount);
            }));
            ToggleNetworkTraining(false);
        }

        protected void UpdateTrainingProgress(int progressCount, int totalCount, long ticks)
        {
            lblTrainingStatus.Invoke(new Action(() => {
                lblTrainingStatus.Text = string.Format("Progress: {0}/{1} ETA: {2}", progressCount, totalCount, TimeSpan.FromTicks(ticks).ToString(@"hh\:mm\:ss"));
                pgbTrainingProgress.Increment(1);
            }));
        }

        protected virtual void UpdateVisualRepresentation()
        {
            Invoke(new Action(() =>
            {
                chtCurrentStateLoss.Series[0].Points.Clear();
                foreach (var point in Network.LossIterations)
                {
                    chtCurrentStateLoss.Series[0].Points.Add(point.Loss, point.TrainingIterations);
                }
            }));
        }

        private async void btnTrain2000_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Train(2000, cancellationTokenSource.Token));
        }

        private async void btnTrainX_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Train(Convert.ToInt32(nudTrainX.Value), cancellationTokenSource.Token));
        }

        private void btnLoadNetwork_Click(object sender, EventArgs e)
        {
            string filePath = Misc.Utility.GetOpenFilePath("Multi-Layer Perceptron", "mlp");
            if (filePath == "")
                return;
            NeuralNetwork network = NeuralNetwork.LoadFromFile(filePath);
            if(network.InputCount != projectSettings.InputCount || network.Configuration.NodeCounts.Last() != projectSettings.OutputCount)
            {
                DarkMessageBox messageBox = new DarkMessageBox();
                messageBox.ShowDialog("The network loaded is incompatable with the project type " + projectSettings.Name + ". " +
                    "\nProject Configuration:\nInput Count: " + projectSettings.InputCount + "  Output Count: " + projectSettings.OutputCount +
                    "\nLoaded Configuration:\nInput Count: " + network.InputCount + "  Output Count: " + network.Configuration.NodeCounts.Last(), "Load Failed - Configuration Mismatch");
                return;
            }
            Network = NeuralNetwork.LoadFromFile(filePath);
            UpdateUIStatus();
        }

        protected virtual async Task<string> GenerateReport()
        {
            if (Inputs == null || ExpectedOutputs == null)
                throw new Exception("Inputs and expeceted outputs must be defined before calling generate report");
            int correct = 0, incorrect = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < Inputs.Length; i++)
                {
                    double[] prediction = Network.Predict(Inputs[i]);
                    if (ResultValidator.OutputsCorrect(Project, prediction, ExpectedOutputs[i]))
                        correct++;
                    else
                        incorrect++;
                }
            });
            string report = string.Format("Correct: {0}\nIncorrect: {1}\nSuccess Rate:{2}%\nNetwork Architecture: {3}\nLearning Rates: {4}\nActivation Methods: {5}", correct, incorrect, (double)correct / incorrect, NetworkArchitectureToString, NetworkLearningRatesToString, NetworkActivationMethodsToString);
            return report;
        }

        private void btnSaveNetwork_Click(object sender, EventArgs e)
        {
            string filePath = Misc.Utility.GetSaveFilePath("Multi-Layer Perceptron", "mlp");
            if (filePath == "")
                return;
            Network.SaveInstance(filePath);
        }

        protected async virtual void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string report = await GenerateReport();
            string path = Misc.Utility.GetSaveFilePath("Text Document", "txt");
            if (path == "")
                return;
            File.WriteAllText(path, report);
        }
        
        private void btnCancelTraining_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
            }
        }

        private void BaseSolutionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Process.GetProcessesByName("magnify").Length != 0)
                Process.GetProcessesByName("magnify").First().Kill();
        }
    }
}
