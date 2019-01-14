using ML_Library;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace XORTest
{
    internal class Program
    {
        private static readonly int trainingIterations = 15000;
        private static NeuralNetwork network;

        private static void Main(string[] args)
        {
            for (; ; )
            {
                network = new NeuralNetwork(2);
                network.AddLayer(8, ActivationMethod.Arctan);
                network.AddLayer(1, ActivationMethod.Arctan);
                network.SetLearningRate(0.2);
                List<double[]> inputs = new List<double[]>() { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
                List<double[]> expectedOutputs = new List<double[]>() { new double[] { 0 }, new double[] { 1 }, new double[] { 1 }, new double[] { 0 }, };
                for (int i = 0; i < trainingIterations; i++)
                {
                    int index = Utility.Next(0, 4);
                    network.Train(inputs[index], expectedOutputs[index]);
                }
                Console.WriteLine(network.Predict(inputs[0])[0] + "   " + network.Predict(inputs[1])[0] + "   " + network.Predict(inputs[2])[0] + "   " + network.Predict(inputs[3])[0]);
            }
        }
        
    }
}
