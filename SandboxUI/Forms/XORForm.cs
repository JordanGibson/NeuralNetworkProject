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

namespace SandboxUI.Forms
{
    public partial class XORForm : BaseSolutionForm
    {
        public XORForm() : base(Project.XOR)
        {
            InitializeComponent();

            Inputs = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            ExpectedOutputs = new double[][] { new double[] { 0 }, new double[] { 1 }, new double[] { 1 }, new double[] { 0 } };
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

        protected override void Train(int iterations)
        {
            ToggleUIEnabled(false);
            for (int i = 0; i < iterations; i++)
            {
                int index = Project == Project.XOR ? Utility.Next(0, Inputs.Length) : TrainedCount % Inputs.Length;
                Network.Train(Inputs[index], ExpectedOutputs[index]);
                TrainedCount++;
            }
            UpdateVisualRepresentation();
            ToggleUIEnabled(true);
        }
    }
}
