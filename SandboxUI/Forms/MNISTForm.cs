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
        private string trainImgPath = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\SandboxUI\Resources\train-images.idx3-ubyte";
        private string trainLblPath = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\SandboxUI\Resources\train-labels.idx1-ubyte";

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
                    var pixel = (int)image[x + (y * 28)];
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
    }
}
