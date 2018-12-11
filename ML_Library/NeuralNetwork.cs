using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ML_Library
{
    /// <summary>Represents a neural network machine learning algorithm.</summary>
    [Serializable]
    public class NeuralNetwork
    {
        /// <summary>Gets or sets the structure of the existing network.</summary>
        /// <value>The structure of the current network.</value>
        [JsonProperty()]
        public List<FullyConnected> Structure { get; protected set; }

        /// <summary>Gets or sets the input count for the existing network.</summary>
        /// <value>The input count.</value>
        [JsonProperty()]
        public int InputCount { get; protected set; }
        /// <summary>Gets the current loss in the current state of the neural network.</summary>
        /// <value>The current loss.</value>
        public double CurrentLoss { get; private set; }
        /// <summary>Gets or sets the learning rate for the overall neural network.</summary>
        /// <value>The learning rate.</value>
        public double LearningRate
        {
            get => Structure[0].LearningRate;
            set
            {
                foreach (FullyConnected layer in Structure)
                {
                    layer.LearningRate = value;
                }
            }
        }



        /// <summary>Initializes a new instance of the <see cref="NeuralNetwork"/> class.</summary>
        /// <param name="inputCount">The input count.</param>
        public NeuralNetwork(int inputCount)
        {
            Structure = new List<FullyConnected>();
            InputCount = inputCount;
            LearningRate = 0.1;
        }

        /// <summary>Adds a layer to the current structure.</summary>
        /// <param name="nodeCount">The node count in the layer to add.</param>
        /// <param name="activationMethod">The activation method of the layer to add.</param>
        public void AddLayer(int nodeCount, ActivationMethod activationMethod)
        {
            Structure.Add(new FullyConnected(nodeCount, activationMethod));
        }

        /// <summary>Copies this instance of the <see cref="NeuralNetwork"/>.</summary>
        public NeuralNetwork Copy()
        {
            NeuralNetwork network = new NeuralNetwork(InputCount)
            {
                Structure = Structure,
                LearningRate = LearningRate
            };
            return network;
        }

        /// <summary>Performs a forward pass with supplied inputs.</summary>
        /// <param name="inputs">The inputs supplied to the forward pass.</param>
        /// <exception cref="ArgumentException">The given arguements do not correspond to the network configuration.</exception>
        public double[] Predict(double[] inputs)
        {
            if (inputs.Length != InputCount)
            {
                throw new ArgumentException("The given arguements do not correspond to the network configuration.");
            }
            double[] outputs = inputs;
            foreach (FullyConnected layer in Structure)
            {
                outputs = layer.ForwardPass(outputs);
            }
            return outputs;
        }

        /// <summary>Performs an iteration of backpropagation using the specified inputs and expected outputs.</summary>
        /// <param name="inputs">The inputs.</param>
        /// <param name="expectedOutputs">The expected outputs.</param>
        /// <exception cref="ArgumentException">The given arguements do not correspond to the network configuration.</exception>
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

        /// <summary>Gets the loss based on the current state of the <see cref="NeuralNetwork"/>.</summary>
        /// <param name="actual">The actual value predicted by the network.</param>
        /// <param name="expected">The expected value.</param>
        private double GetLoss(double[] actual, double[] expected)
        {
            double loss = 0;
            for (int i = 0; i < actual.Length; i++)
            {
                loss += Math.Pow(expected[i] - actual[i], 2);
            }
            return loss / actual.Length;
        }

        /// <summary>Saves this instance to the specified path.</summary>
        /// <param name="path">The path.</param>
        public void Save(string path)
        {
            string output = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, output);
        }

        /// <summary>Loads an instance of a <see cref="NeuralNetwork"/> from a Json file.</summary>
        /// <param name="path">The path to load from.</param>
        public static NeuralNetwork LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<NeuralNetwork>(File.ReadAllText(path));
        }
    }
}