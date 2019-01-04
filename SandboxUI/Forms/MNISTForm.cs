using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML_Library.ConvNet;

namespace SandboxUI.Forms
{
    public partial class MNISTForm : BaseSolutionForm
    {
        public List<byte> trainImagesBytes;
        public List<byte> trainLabelsBytes;
        public new ConvolutionalNetwork Network;

        private int currentExample = 0;


        public MNISTForm()
        {
            InitializeComponent();

            Network = ConvolutionalNetwork.DebugNet;
        }

        private void btnShowConvDisplay_Click(object sender, EventArgs e)
        {
            ConvolutionalDisplayDialog convolutionalDisplay = new ConvolutionalDisplayDialog(Network);
            convolutionalDisplay.ShowDialog();
        }

        private double[] GetMNISTImage()
        {
            List<double> value = trainImagesBytes.GetRange(currentExample * 784 + 16, 784).Select(o => Convert.ToDouble(o)).ToList();
            value.Insert(0, Convert.ToDouble(trainLabelsBytes[8 + currentExample]));
            return value.ToArray();
        }

        private Bitmap LoadMNISTImage()
        {
            double[] imageWithLabel = GetMNISTImage();
            Bitmap bmp = new Bitmap(28, 28);
            for (int x = 0; x < 28; x++)
            {
                for (int y = 0; y < 28; y++)
                {
                    var pixel = (int)imageWithLabel[x + (y * 28) + 1];
                    var color = Color.FromArgb(pixel, pixel, pixel);
                    bmp.SetPixel(x, y, color);
                }
            }
            return bmp;
        }

        private void MNISTForm_Load(object sender, EventArgs e)
        {
            trainImagesBytes = File.ReadAllBytes(@"C:\Users\Jordan\Desktop\train-images.idx3-ubyte").ToList();
            trainLabelsBytes = File.ReadAllBytes(@"C:\Users\Jordan\Desktop\train-labels.idx1-ubyte").ToList();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            currentExample++;
            pbxVisualRepresentation.Image = new Bitmap(LoadMNISTImage(), new Size(pbxVisualRepresentation.Width, pbxVisualRepresentation.Height));
            Network.ForwardPropagate(Matrix3D.FromBitmap(LoadMNISTImage(), true));
        }

        public override void btnNewNetwork_Click(object sender, EventArgs e)
        {
            pnlNetworkTraining.Enabled = true;
            btnShowConvDisplay.Enabled = true;
        }
    }
}
