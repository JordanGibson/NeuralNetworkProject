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
        private string trainImgPath = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\SandboxUI\Resources\train-images.idx3-ubyte";
        private string trainLblPath = @"C:\Users\Jordan\source\repos\JordanGibsonNEA\SandboxUI\Resources\train-labels.idx1-ubyte";
        private string testImgPath = @"";
        private string testLblPath = @"";


        public MNISTForm() : base(ProjectHelper.Project.MNIST)
        {
            InitializeComponent();


        }

        protected override async void Train(int iterations, CancellationToken cancellationToken)
        {
            Inputs = await MNISTLoader.GetImagesAsync(trainImgPath, TrainedCount % 50000, iterations);
            ExpectedOutputs = await MNISTLoader.GetLabelsAsync(trainLblPath, TrainedCount % 50000, iterations);

            base.Train(iterations, cancellationToken);
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
    }
}
