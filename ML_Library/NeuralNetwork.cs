using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

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

        public bool HasLayers { get { return Structure.Count != 0; } }

        public double Fitness { get; set; }
        /// <summary>Initializes a new instance of the <see cref="NeuralNetwork"/> class.</summary>
        /// <param name="inputCount">The input count.</param>
        public NeuralNetwork(int inputCount)
        {
            Structure = new List<FullyConnected>();
            InputCount = inputCount;
        }

        public void SetLearningRate(double learningRate)
        {
            foreach(var layer in Structure)
            {
                layer.LearningRate = learningRate;
            }
        }

        public void SetLearningRate(double learningRate, int layer)
        {
            Structure[layer].LearningRate = learningRate;
        }

        /// <summary>Adds a layer to the current structure.</summary>
        /// <param name="nodeCount">The node count in the layer to add.</param>
        /// <param name="activationMethod">The activation method of the layer to add.</param>
        public void AddLayer(int nodeCount)
        {
            Structure.Add(new FullyConnected(nodeCount));
        }

        /// <summary>Copies this instance of the <see cref="NeuralNetwork"/>.</summary>
        public NeuralNetwork Copy()
        {
            NeuralNetwork network = new NeuralNetwork(InputCount)
            {
                Structure = Structure
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

        public NeuralNetwork Breed(NeuralNetwork partner, double mutationPercentage = 0.05)
        {
            NeuralNetwork child = new NeuralNetwork(InputCount);
            for(int i = 0; i < Structure.Count; i++)
            {
                var crossedOver = Structure[i].Crossover(partner.Structure[i]);
                var mutated = crossedOver.Mutate(mutationPercentage);
                child.Structure.Add(mutated);
            }
            return child;
        }

        /// <summary>Saves this instance to the specified path.</summary>
        /// <param name="path">The path.</param>
        public void SaveInstance(string path)
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