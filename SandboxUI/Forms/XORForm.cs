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
using SandboxUI.Dialogs;


namespace SandboxUI.Forms
{
    public partial class XORForm : BaseSolutionForm
    {
        private double[][] inputs = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
        private double[][] expectedOutputs = new double[][] { new double[] { 0 }, new double[] { 1 }, new double[] { 1 }, new double[] { 0 } };

        public XORForm() : base(Project.XOR)
        {
            InitializeComponent();
        }

        protected override void Train(int iterations, CancellationToken cancellationToken)
        {
            Inputs = inputs;
            ExpectedOutputs = expectedOutputs;

            base.TrainRandomOrder(iterations, cancellationToken);
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
            base.UpdateVisualRepresentation();
        }

        protected override async Task<string> GenerateReport()
        {
            Inputs = inputs;
            ExpectedOutputs = expectedOutputs;
            return await base.GenerateReport();
        }
    }
}
