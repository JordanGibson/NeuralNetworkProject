using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML_Library.ConvNet;

namespace SandboxUI.Forms
{
    public partial class ConvolutionalDisplayDialog : BaseDialog
    {
        public ConvolutionalNetwork Network { get; set; }

        public ConvolutionalDisplayDialog()
        {
            InitializeComponent();
        }

        public ConvolutionalDisplayDialog(ConvolutionalNetwork convNet)
        {
            InitializeComponent();

            Network = convNet;
            btnStartup.Tag = 0;
            int convCount = 1, activationCount = 0, poolingCount = 0;
            for(int i = 1; i < Network.Structure.Count; i++)
            {
                DarkButton button = new DarkButton() { Size = new Size(135, 37)};
                switch (Network.Structure[i].LayerType)
                {
                    case (LayerType.Activation):
                        activationCount++;
                        button.Text = "Activation " + activationCount;
                        break;
                    case (LayerType.Pooling):
                        poolingCount++;
                        button.Text = "Pooling " + poolingCount;
                        break;
                    case (LayerType.Convolutional):
                        convCount++;
                        button.Text = "Convolutional " + convCount;
                        break;
                }
                if (button.Text != "")
                {
                    button.Tag = i;
                    button.Click += Button_Click;
                    flpButtonHeaders.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            flpConvDisplay.Controls.Clear();
            int index = (int)((Button)sender).Tag;
            Bitmap[] outputSpace = Network.BitmapsFromActivations(index);
            foreach(var bitmap in outputSpace)
            {
                flpConvDisplay.Controls.Add(new PictureBox() { Image = new Bitmap(bitmap, new Size(bitmap.Width * 3, bitmap.Height * 3)), AutoSize = true });
            }
            var currentLayer = Network.Structure[index];
            lblLayerDetails.Text = string.Format("Input Size: {0} x {1}     Result Size: {2} x {3}", currentLayer.InputSpace.Rows, currentLayer.InputSpace.Cols, outputSpace[0].Width, outputSpace[1].Height);
            if(currentLayer is ConvLayer)
            {
                var layer = currentLayer as ConvLayer;
                lblLayerDetails.Text += string.Format("       Filter Size: {0}       Stride: {1}       Filter Count: {2}     Padding: {3}", layer.FilterSize, layer.Stride, layer.Filters.Length, layer.Padding);
            }
            else if(currentLayer is PoolingLayer)
            {
                var layer = currentLayer as PoolingLayer;
                lblLayerDetails.Text += string.Format("       Pool Size: {0}       Stride: {1}      ", layer.PoolSize, layer.Stride);
            }
        }

        private void ConvolutionalDisplayDialog_Load(object sender, EventArgs e)
        {
            Bitmap[] outputSpace = Network.BitmapsFromActivations(0);
            foreach (var bitmap in outputSpace)
            {
                flpConvDisplay.Controls.Add(new PictureBox() { Width = 100, Height = 100, Image = new Bitmap(bitmap, new Size(100, 100)) });
            }
        }
    }
}
