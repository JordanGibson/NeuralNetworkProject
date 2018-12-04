using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML_Library;

namespace XORTest
{
    class Program
    {
        static int trainingIterations = 5000;
        static ActivationMethod activationMethod = ActivationMethod.LreLU;
        static NeuralNetwork network = new NeuralNetwork(2);

        static void Main(string[] args)
        {
            network.AddLayer(8, activationMethod);
            network.AddLayer(4, activationMethod);
            network.AddLayer(2, activationMethod);
            network.AddLayer(1, activationMethod);

            network.LearningRate = 0.2;

            List<double[]> inputs = new List<double[]>() { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 }};
            List<double[]> expectedOutputs = new List<double[]>() { new double [] { 0 }, new double[] { 1 }, new double[] { 1 }, new double[] { 0 }, };
            for(int i = 0; i < trainingIterations; i++)
            {
                int index = Utility.Next(0, 4);
                network.Train(inputs[index], expectedOutputs[index]);
            }
            Console.WriteLine("Expected: 0         Actual: {0}", network.Predict(inputs[0])[0]);
            Console.WriteLine("Expected: 1         Actual: {0}", network.Predict(inputs[1])[0]);
            Console.WriteLine("Expected: 1         Actual: {0}", network.Predict(inputs[2])[0]);
            Console.WriteLine("Expected: 0         Actual: {0}", network.Predict(inputs[3])[0]);
            Console.ReadLine();
        }
    }
}
