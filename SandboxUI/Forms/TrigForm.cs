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
    public partial class TrigForm : BaseSolutionForm
    {
        public TrigFunction Function { get; set; }

        public TrigForm() : base(Project.Trig)
        {
            InitializeComponent();
        }

        private void TrigForm_Load(object sender, EventArgs e)
        {
            cboFunction.DataSource = Enum.GetValues(typeof(TrigFunction));
        }

        private void cboFunction_SelectedValueChanged(object sender, EventArgs e)
        {
            Function = (TrigFunction)cboFunction.SelectedItem;
        }

        protected override void Train(int iterations, CancellationToken cancellationToken)
        {
            Inputs = Enumerable.Range(0, (int)(Math.PI * 20000)).Select(o => new double[] { o / 10000 }).ToArray();
            ExpectedOutputs = Inputs.Select(o => new double[] { Math.Sin(o[0]) }).ToArray();

            base.Train(iterations, cancellationToken);
        }

        protected override void UpdateVisualRepresentation()
        {
            double resolution = pbxVisualRepresentation.Width;
            Bitmap bmp = new Bitmap(1, 1);
            bmp.SetPixel(0, 0, Color.Black);
            bmp = new Bitmap(bmp, new Size(Convert.ToInt32(resolution), Convert.ToInt32(resolution)));
            for (int x = 0; x < resolution; x++)
            {
                var y = Network.Predict(new double[] { Utility.Map(x, 0, resolution, 0, 2 * Math.PI) })[0];
                bmp.SetPixel(x, (int)Utility.Map(Utility.Clamp(y, -1, 1), -1, 1, resolution, 0), Color.White);
            }
            pbxVisualRepresentation.Image = bmp;
            base.UpdateVisualRepresentation();
        }
    }
}
