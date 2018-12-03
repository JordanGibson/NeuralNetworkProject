using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ML_Library
{
    [Serializable]
    public class NeuralNetwork
    {
        [JsonProperty()]
        public List<FullyConnected> Structure { get; protected set; }

        [JsonProperty()]
        public int InputCount { get; protected set; }
        public double CurrentLoss { get; private set; }
        public double LearningRate
        {
            get { return Structure[0].LearningRate; }
            set
            {
                foreach (var layer in Structure)
                {
                    layer.LearningRate = value;
                }
            }
        }



        public NeuralNetwork(int inputCount)
        {
            Structure = new List<FullyConnected>();
            InputCount = inputCount;
            LearningRate = 0.1;
        }

        public void AddLayer(int nodeCount, ActivationMethod activationMethod)
        {
            Structure.Add(new FullyConnected(nodeCount, activationMethod));
        }

        public NeuralNetwork Copy()
        {
            NeuralNetwork mlp = new NeuralNetwork(InputCount);
            mlp.Structure = Structure;
            mlp.LearningRate = LearningRate;
            return mlp;
        }

        public double[] Predict(double[] inputs)
        {
            if (inputs.Length != InputCount)
            {
                throw new ArgumentException("The given arguements do not correspond to the network configuration.");
            }
            double[] outputs = inputs;
            foreach (var layer in Structure)
            {
                outputs = layer.ForwardPass(outputs);
            }
            return outputs;
        }

        public void Train(double[] inputs, double[] expectedOutputs)
        {
            if (inputs.Length != InputCount || expectedOutputs.Length != Structure.Last().NodeCount)
            {
                throw new ArgumentException("The given arguements do not correspond to the network configuration.");
            }

            double[] actualOutput = Predict(inputs);
            CurrentLoss = GetLoss(actualOutput, expectedOutputs);
            double[] errors = expectedOutputs.ElementwiseSubtract(actualOutput);
            for (int currentLayer = Structure.Count - 1; currentLayer > -1; currentLayer--)
            {
                errors = Structure[currentLayer].Backpropagate(errors);
            }
        }

        private double GetLoss(double[] actual, double[] expected)
        {
            double loss = 0;
            for (int i = 0; i < actual.Length; i++)
            {
                loss += Math.Pow(expected[i] - actual[i], 2);
            }
            return loss / actual.Length;
        }

        public void Save(string path)
        {
            string output = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, output);
        }

        public static NeuralNetwork LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<NeuralNetwork>(File.ReadAllText(path));
        }
    }
}