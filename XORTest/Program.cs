using ML_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace XORTest
{
    internal class Program
    {
        public static readonly int trainingIterations = 10000;
        public static NeuralNetwork network;

        [STAThread]
        public static void Main(string[] args)
        {

            Matrix x = new Matrix(2, 2);
            //network = new NeuralNetwork(2);
            //network.AddLayer(8, ActivationMethod.ReLU);
            //network.AddLayer(1, ActivationMethod.Arctan);
            //network.SetLearningRate(0.1);
            //List<double[]> inputs = new List<double[]>() { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            //List<double[]> expectedOutputs = new List<double[]>() { new double[] { 0 }, new double[] { 1 }, new double[] { 1 }, new double[] { 0 }, };
            //for (int i = 0; i < trainingIterations; i++)
            //{
            //    int index = Utility.Next(0, 4);
            //    network.Train(inputs[index], expectedOutputs[index]);
            //}
            //Console.WriteLine("Input: 0, 0     Output: " + network.Feedforward(inputs[0])[0]);
            //Console.WriteLine("Input: 0, 1     Output: " + network.Feedforward(inputs[1])[0]);
            //Console.WriteLine("Input: 1, 0     Output: " + network.Feedforward(inputs[2])[0]);
            //Console.WriteLine("Input: 1, 1     Output: " + network.Feedforward(inputs[3])[0]);
            //Console.ReadLine();
        }

    }
}
