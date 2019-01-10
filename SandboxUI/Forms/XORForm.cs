using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML_Library;
using SandboxUI.ProjectHelper;

namespace SandboxUI.Forms
{
    public partial class XORForm : BaseSolutionForm
    {
        public XORForm() : base(Project.XOR)
        {
            InitializeComponent();
        }

        protected override async void Train(int iterations, CancellationToken cancellationToken)
        {
            var trainingData = await Misc.XORLoader.GetTrainingDataAsync(iterations);
            Inputs = trainingData.Item1;
            ExpectedOutputs = trainingData.Item2;

            base.Train(iterations, cancellationToken);
        }

        protected override void UpdateVisualRepresentation()
        {
            double resolution = pbxVisualRepresentation.Width;
            Bitmap bmp = new Bitmap(Convert.ToInt32(resolution), Convert.ToInt32(resolution));
            for (int y = 0; y < resolution; y++)
            {
                for (int x = 0; x < resolution; x++)
                {
                    var tone = Convert.ToInt32(Utility.Clamp(Network.Predict(new double[] { x / resolution, y / resolution })[0] * 255, 0, 255));
                    bmp.SetPixel(x, y, Color.FromArgb(tone, tone, tone));
                }
            }
            pbxVisualRepresentation.Image = bmp;
        }

        protected override async Task<string> GenerateReport()
        {
            var trainingData = await Misc.XORLoader.GetTrainingDataAsync(1000);
            Inputs = trainingData.Item1;
            ExpectedOutputs = trainingData.Item2;
            return await base.GenerateReport();
        }
    }
}
