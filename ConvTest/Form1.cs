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
using ML_Library;
using ML_Library.ConvNet;

namespace ConvTest
{
    public partial class Form1 : Form
    {
        public List<byte> trainImagesBytes;
        public List<byte> trainLabelsBytes;

        private int currentExample = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public double[] GetNextMNISTImage()
        {
            List<double> value = trainImagesBytes.GetRange(currentExample * 784 + 16, 784).Select(o => Convert.ToDouble(o)).ToList();
            value.Insert(0, Convert.ToDouble(trainLabelsBytes[8 + currentExample]));
            currentExample++;
            return value.ToArray();
        }

        public Image LoadMNISTImage()
        {
            double[] imageWithLabel = GetNextMNISTImage();
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
            return bmp as Image;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            flpPictureBoxes.Controls.Clear();
            Image originalImage = LoadMNISTImage();
            Matrix3D imageAsMatrix = MatrixFromBitmap(originalImage, true);
            ConvolutionalNetwork network = ConvolutionalNetwork.DebugNet;
        }
        
        private bool BitmapEquals(Bitmap a, Bitmap b)
        {
            if (a.Width != b.Width || a.Height != b.Height)
                return false;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    if (a.GetPixel(x, y) != b.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }

        private Bitmap[] BitmapsFromActivations(Matrix3D matrix)
        {
            Bitmap[] imageList = new Bitmap[matrix.Depth];
            for (int filter = 0; filter < matrix.Depth; filter++)
            {
                Bitmap bmp = new Bitmap(matrix.Rows, matrix.Cols);
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        var pixel = Convert.ToInt32(Utility.Clamp(matrix[filter, x, y] * 255, 0, 255));
                        var color = Color.FromArgb(pixel, pixel, pixel);
                        bmp.SetPixel(x, y, color);
                    }
                }
                imageList[filter] = bmp;
            }
            return imageList;
        }

        private Matrix3D MatrixFromBitmap(Image image, bool greyscale)
        {
            Bitmap bmp = new Bitmap(image);
            Matrix3D matrix = new Matrix3D(bmp.Width, bmp.Height, greyscale ? 1 : 3);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    matrix[0, x, y] = (double)bmp.GetPixel(x, y).R / 255;
                    if (!greyscale)
                    {
                        matrix[1, x, y] = (double)bmp.GetPixel(x, y).G / 255;
                        matrix[2, x, y] = (double)bmp.GetPixel(x, y).B / 255;

                    }
                }
            }
            return matrix;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trainImagesBytes = File.ReadAllBytes(@"C:\Users\Jordan\Desktop\train-images.idx3-ubyte").ToList();
            trainLabelsBytes = File.ReadAllBytes(@"C:\Users\Jordan\Desktop\train-labels.idx1-ubyte").ToList();
        }
    }
}
