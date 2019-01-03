using ML_Library;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace XORTest
{
    internal class Program
    {
        private static readonly int trainingIterations = 5000;
        private static NeuralNetwork network;

        private static void Main(string[] args)
        {
            network = NeuralNetwork.LoadFromFile(@"C:\Users\Jordan\Desktop\XORAnimation\network.ntk");
            List<double[]> inputs = new List<double[]>() { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            List<double[]> expectedOutputs = new List<double[]>() { new double[] { 0 }, new double[] { 1 }, new double[] { 1 }, new double[] { 0 }, };
            for (int i = 0; i < trainingIterations; i++)
            {
                int index = Utility.Next(0, 4);
                network.Train(inputs[index], expectedOutputs[index]);
                GenerateImage().Save(@"C:\Users\Jordan\Desktop\XORAnimation\frame" + i + 1 + ".jpg" , System.Drawing.Imaging.ImageFormat.Jpeg);
                Console.WriteLine(i + "/" + trainingIterations);
            }
            Console.WriteLine(network.Predict(inputs[0])[0] + "   " + network.Predict(inputs[1])[0] + "   " + network.Predict(inputs[2])[0] + "   " + network.Predict(inputs[3])[0]);
            Console.ReadLine();
        }

        private static Bitmap GenerateImage()
        {
            double resolution = 300;
            Bitmap bmp = new Bitmap(Convert.ToInt32(resolution), Convert.ToInt32(resolution));
            for (int y = 0; y < resolution; y++)
            {
                for (int x = 0; x < resolution; x++)
                {
                    var tone = Convert.ToInt32(Utility.Clamp(network.Predict(new double[] { x / resolution, y / resolution })[0] * 255, 0, 255));
                    bmp.SetPixel(x, y, Color.FromArgb(tone, tone, tone));
                }
            }
            return bmp;
        }
    }
}
