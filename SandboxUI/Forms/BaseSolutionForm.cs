using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using Bunifu.Framework;
using Bunifu;
using BunifuAnimatorNS;
using ML_Library;
using SandboxUI.ProjectHelper;

namespace SandboxUI.Forms
{
    public partial class BaseSolutionForm : Form
    {
        protected NeuralNetwork Network;
        protected Project Project;
        protected ProjectSettings projectSettings;

        protected double[][] Inputs;
        protected double[][] ExpectedOutputs;
        protected int TrainedCount;

        public bool isTrainingDataLoaded { get { return Inputs != null && ExpectedOutputs != null; } }


        public BaseSolutionForm()
        {
            InitializeComponent();
        }

        public BaseSolutionForm(Project project)
        {
            InitializeComponent();

            projectSettings = ProjectSettings.GetSettings(project);
            lblWindowTitle.Text = projectSettings.Name;
        }

        public virtual double GetCurrentError()
        {
            throw new NotImplementedException();
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
                lblNetworkStructure.Text = "Structure: " + Network.InputCount + "-" + string.Join("-", Network.Structure.Select(l => l.NodeCount));
                if (Network.CurrentError == double.PositiveInfinity)
                    lblCurrentError.Text = "Current Error: N/A";
                else
                    lblCurrentError.Text = "Current Error: " + Network.CurrentError;
            }
            else
            {
                lblLearningRate.Text = "Show Learning Rates";
                lblActivationMethod.Text = "Show Activation Methods";
                lblNetworkStructure.Text = "Structure: N/A";
                lblCurrentError.Text = "Current Error: N/A";
                pbxVisualRepresentation.Image = null;
            }
            AdditionalUIStatusUpdate();
        }

        protected virtual void AdditionalUIStatusUpdate()
        {

        }

        protected void ToggleNetworkTraining(bool enabled)
        {
            pnlNetworkConfiguration.BeginInvoke(new Action(() => {
                pnlNetworkConfiguration.Enabled = !enabled;
                pnlNetworkTraining.Enabled = !enabled;
                pnlTrainingStatus.Visible = enabled;
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
            await Task.Run(() => Train(500));
        }

        protected virtual void Train(int iterations)
        {
            throw new NotImplementedException();
        }

        protected virtual void UpdateVisualRepresentation()
        {
            
        }

        private async void btnTrain2000_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Train(2000));
        }

        private void nudTrainX_ValueChanged(object sender, EventArgs e)
        {
            btnTrainX.Text = string.Format("Train {0} Iterations", nudTrainX.Value);
        }

        private async void btnTrainX_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Train(Convert.ToInt32(nudTrainX.Value)));
        }

        private void nudTrainX_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnTrainX.Text = string.Format("Train {0} Iterations", nudTrainX.Value);
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
            }
            Network = NeuralNetwork.LoadFromFile(filePath);
            UpdateUIStatus();
        }

        private void btnSaveNetwork_Click(object sender, EventArgs e)
        {
            string filePath = Misc.Utility.GetSaveFilePath("Multi-Layer Perceptron", "mlp");
            if (filePath == "")
                return;
            Network.SaveInstance(filePath);
        }
    }
}
