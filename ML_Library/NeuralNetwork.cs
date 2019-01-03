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

        public bool HasLayers { get { return Structure.Count != 0; } }

        /// <summary>Gets or sets the learning rate for the overall neural network.</summary>
        /// <value>The learning rate.</value>
        public double[] LearningRates { get { return Structure.Select(l => l.LearningRate).ToArray(); }  }
        
        public ActivationMethod[] ActivationMethods { get { return Structure.Select(l => l.ActivationMethod).ToArray(); } }

        public double CurrentError { get; private set; } = double.PositiveInfinity;

        public Configuration Configuration
        {
            get
            {
                Configuration config = new Configuration(Structure.Count);
                for(int i = 0; i < Structure.Count; i++)
                {
                    config.ActivationMethods[i] = Structure[i].ActivationMethod;
                    config.NodeCounts[i] = Structure[i].NodeCount;
                    config.LearningRates[i] = Structure[i].LearningRate;
                }
                config.InputCount = InputCount;
                return config;
            }
        }

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
        public void AddLayer(int nodeCount, ActivationMethod activationMethod)
        {
            Structure.Add(new FullyConnected(nodeCount, activationMethod));
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
            double[] errors = expectedOutputs.ElementwiseSubtract(actualOutput);
            for (int currentLayer = Structure.Count - 1; currentLayer > -1; currentLayer--)
            {
                errors = Structure[currentLayer].Backpropagate(errors);
            }
        }

        /// <summary>Saves this instance to the specified path.</summary>
        /// <param name="path">The path.</param>
        public void SaveInstance(string path)
        {
            string output = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, output);
        }

        /// <summary>Saves the configuration for the current instance.</summary>
        /// <param name="path">The path to save to.</param>
        public void SaveConfiguration(string path)
        {
            string output = JsonConvert.SerializeObject(Configuration);
            File.WriteAllText(path, output);
        } 

        /// <summary>Loads an instance of a <see cref="NeuralNetwork"/> from a Json file.</summary>
        /// <param name="path">The path to load from.</param>
        public static NeuralNetwork LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<NeuralNetwork>(File.ReadAllText(path));
        }

        /// <summary>Loads a new instance of <see cref="NeuralNetwork"/> from configuration file.</summary>
        /// <param name="path"> The path to load the configuration file. </param>
        /// <returns></returns>
        public static NeuralNetwork LoadFromConfigurationFile(string path)
        {
            return LoadFromConfiguration(JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(path)));
        }

        /// <summary>Loads a new instance of <see cref="NeuralNetwork"/> from a configuration instance.</summary>
        /// <param name="config">The configuration to load network from.</param>
        /// <returns></returns>
        public static NeuralNetwork LoadFromConfiguration(Configuration config)
        {
            NeuralNetwork neuralNetwork = new NeuralNetwork(config.InputCount);
            for(int i = 0; i < config.NodeCounts.Length; i++)
            {
                neuralNetwork.AddLayer(config.NodeCounts[i], config.ActivationMethods[i]);
                neuralNetwork.Structure[i].LearningRate = config.LearningRates[i];
                neuralNetwork.InputCount = config.InputCount;
            }
            return neuralNetwork;
        }
    }
}