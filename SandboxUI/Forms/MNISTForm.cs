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
using SandboxUI.Misc;
using SandboxUI.Dialogs;


namespace SandboxUI.Forms
{
    public partial class MNISTForm : BaseSolutionForm
    {
        public string trainImgPath = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\SandboxUI\Resources\train-images.idx3-ubyte";
        public string trainLblPath = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\SandboxUI\Resources\train-labels.idx1-ubyte";
        public string testImgPath = @"C:\Users\Jordan\Desktop\t10k-images - Copy.idx3-ubyte";
        public string testLblPath = @"C:\Users\Jordan\Desktop\t10k-labels - Copy.idx1-ubyte";
        
        public MNISTForm() : base(ProjectHelper.Project.MNIST)
        {
            InitializeComponent();


        }

        protected override async void Train(int iterations, CancellationToken cancellationToken)
        {
            Inputs = await MNISTLoader.GetImagesAsync(trainImgPath, 0, iterations);
            ExpectedOutputs = await MNISTLoader.GetLabelsAsync(trainLblPath, 0, iterations);

            base.Train(iterations, cancellationToken);
        }

        public Bitmap LoadMNISTImage(double[] image)
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

        protected override async void btnGenerateReport_Click(object sender, EventArgs e)
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
                    List<double> prediction = Network.Feedforward(Inputs[i]).ToList();
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
            string report = string.Format("Correct: {0}\nIncorrect: {1}\nSuccess Rate:{2}%\nNetwork Architecture: {3}\nLearning Rates: {4}\nActivation Methods: {5}", correct, incorrect, (double)correct / (correct + incorrect), NetworkArchitectureToString, NetworkLearningRatesToString, NetworkActivationMethodsToString);

            File.WriteAllText(filePath, report);
            ToggleNetworkTraining(false);
        }
    }
}
