using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML_Library;

namespace SandboxUI.Forms
{
    public partial class MNISTForm : BaseSolutionForm
    {
        private CancellationTokenSource cancellationTokenSource;
        private string trainImgPath = @"C:\Users\jorda\Source\Repos\JordanGibson\NeuralNetworkProject3\SandboxUI\Resources\train-images.idx3-ubyte";
        private string trainLblPath = @"C:\Users\jorda\Source\Repos\JordanGibson\NeuralNetworkProject3\SandboxUI\Resources\train-labels.idx1-ubyte";
        private string testImgPath = @"C:\Users\jorda\Downloads\t10k-images.idx3-ubyte";
        private string testLblPath = @"C:\Users\jorda\Downloads\t10k-labels.idx1-ubyte";

        public MNISTForm() : base(ProjectHelper.Project.MNIST)
        {
            InitializeComponent();


        }

        protected override void Train(int iterations)
        {
            cancellationTokenSource = new CancellationTokenSource();
            Train(iterations, cancellationTokenSource.Token);
        }

        private async void Train(int iterations, CancellationToken cancellationToken)
        {
            Inputs = await Misc.MNISTLoader.GetImagesAsync(trainImgPath, TrainedCount % 50000, iterations);
            ExpectedOutputs = await Misc.MNISTLoader.GetLabelsAsync(trainLblPath, TrainedCount % 50000, iterations);

            ToggleNetworkTraining(true);
            Invoke(new Action(() => pgbTrainingProgress.Maximum = iterations));
            Stopwatch stopwatch = Stopwatch.StartNew();

            Progress<int> progress = new Progress<int>();
            long ticks = 0;
            progress.ProgressChanged += (sender, e) => {
                if (e % 5 == 0)
                    ticks = (long)((double)stopwatch.Elapsed.Ticks / e * (iterations - e));
                UpdateTrainingProgress(e, iterations, ticks);
                if (e % 5000 == 0)
                    Network.SaveInstance(@"C:\Users\jorda\Documents\trained" + (e + 10000) + "k.mlp");
                TrainedCount++; };

            Network.Train(Inputs, ExpectedOutputs, progress, cancellationToken);
            
            UpdateVisualRepresentation();
            ToggleNetworkTraining(false);
        }

        private void UpdateTrainingProgress(int progressCount, int totalCount, long ticks)
        {
            lblTrainingStatus.Invoke(new Action(() => {
                lblTrainingStatus.Text = string.Format("Progress: {0}/{1} ETA: {2}", progressCount, totalCount, TimeSpan.FromTicks(ticks).ToString(@"hh\:mm\:ss"));
                pgbTrainingProgress.Increment(1);
            }));
        }

        private Bitmap LoadMNISTImage(double[] image)
        {
            Bitmap bmp = new Bitmap(28, 28);
            for (int x = 0; x < 28; x++)
            {
                for (int y = 0; y < 28; y++)
                {
                    var pixel = (int)Utility.Clamp(image[x + (y * 28)] * 255, 0, 255);
                    var color = Color.FromArgb(pixel, pixel, pixel);
                    bmp.SetPixel(x, y, color);
                }
            }
            return bmp;
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            pbxVisualRepresentation.Image = new Bitmap(LoadMNISTImage(Inputs[TrainedCount]), new Size(pbxVisualRepresentation.Width, pbxVisualRepresentation.Height));
            double[] prediction = Network.Predict(Inputs[TrainedCount]);
            lblTrainingStatus.Text = string.Format("Actual: {0} Predicted: {1}", ExpectedOutputs[TrainedCount].ToList().IndexOf(ExpectedOutputs[TrainedCount].Max()), prediction.ToList().IndexOf(prediction.Max()));
            TrainedCount++;
        }

        private void btnCancelTraining_Click(object sender, EventArgs e)
        {
            if(cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
            }
        }

        private async void MNISTForm_Load(object sender, EventArgs e)
        {
            Inputs = await Misc.MNISTLoader.GetImagesAsync(trainImgPath, 0, 100);
            ExpectedOutputs = await Misc.MNISTLoader.GetLabelsAsync(trainLblPath, 0, 100);
        }

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string filePath = Misc.Utility.GetSaveFilePath("Text Document", "txt");
            if (filePath == "")
                return;

            ToggleNetworkTraining(true);

            Inputs = await Misc.MNISTLoader.GetImagesAsync(testImgPath, 0, 10000);
            ExpectedOutputs = await Misc.MNISTLoader.GetLabelsAsync(testLblPath, 0, 10000);

            IProgress<double> progress = new Progress<double>(new Action<double>((i) => UpdateTrainingProgress((int)i, 10000, 0)));

            int correct = 0, incorrect = 0;

            await Task.Run(() =>
            {
                for (int i = 0; i < Inputs.Length; i++)
                {
                    List<double> prediction = Network.Predict(Inputs[i]).ToList();
                    if (prediction.IndexOf(prediction.Max()) == ExpectedOutputs[i].ToList().IndexOf(1))
                    {
                        correct++;
                    }
                    else
                    {
                        incorrect++;
                    }
                    progress.Report(i);
                }
            });

            File.WriteAllText(filePath, string.Format("Correct: {1} {0} {0} Incorrect: {2} {0} {0} Success Rate: {3}%", Environment.NewLine, correct, incorrect, (double)correct / 100));
            ToggleNetworkTraining(false);
        }
    }
}
