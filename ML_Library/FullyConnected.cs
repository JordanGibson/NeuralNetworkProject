using Newtonsoft.Json;
using System;

namespace ML_Library
{
    /// <summary>Represents a layer of fully connected nodes in a neural network.</summary>
    [Serializable]
    public class FullyConnected
    {
        [JsonProperty()]
        public double LearningRate { get; set; }
        [JsonProperty()]
        public int InputCount { get; set; }
        [JsonProperty()]
        public int NodeCount { get; set; }
        [JsonProperty()]
        public double[] Outputs { get; set; }

        [JsonProperty()]
        public Matrix Weights { get; set; }
        [JsonProperty()]
        private Matrix Biases { get; set; }

        private Matrix Inputs { get; set; }

        private bool IsInitialized => Weights != null && Biases != null;

        /// <summary>Initializes a new instance of the <see cref="FullyConnected"/> class.</summary>
        /// <param name="nodesInLayer">The number of nodes in the layer.</param>
        /// <param name="activationMethod">The activation method to use on this layer.</param>
        public FullyConnected(int nodesInLayer)
        {
            NodeCount = nodesInLayer;
        }

        /// <summary>
        /// Initializes the weights using Xavier Initialization.
        /// </summary>
        /// <param name="inputCount">The input count.</param>
        private void InitializeWeights(int inputCount)
        {
            InputCount = inputCount;

            Weights = new Matrix(NodeCount, InputCount);
            double standardDeviation = 1 / (double)InputCount;
            for (int i = 0; i < Weights.Rows; i++)
            {
                for (int j = 0; j < Weights.Cols; j++)
                {
                    Weights.Data[i, j] = MathExtension.RandomGaussian(0, standardDeviation);
                }
            }
        }

        /// <summary>
        /// Initializes the biases to random values.
        /// </summary>
        private void InitializeBiases()
        {
            Biases = new Matrix(NodeCount, 1, true);
        }


        /// <summary>
        /// Initializes the weights and biases to random values for this layer.
        /// </summary>
        /// <param name="inputCount">The input count.</param>
        private void InitializeLayer(int inputCount)
        {
            InitializeWeights(inputCount);
            InitializeBiases();
        }

        /// <summary>
        /// Performs a forward pass on the network.
        /// </summary>
        /// <param name="inputArr">Array of inputs.</param>
        /// <returns>Result of the forward pass</returns>
        public double[] ForwardPass(double[] inputArr)
        {
            Inputs = Matrix.FromArray(inputArr);

            if (!IsInitialized)
            {
                InitializeLayer(inputArr.Length);
            }

            Outputs = Weights.DotProduct(Inputs).Add(Biases).ToArray();

            return Outputs;
        }

        internal FullyConnected Crossover(FullyConnected partner)
        {
            FullyConnected newLayer = Utility<FullyConnected>.DeepClone(this);
            for(int x = 0; x < Weights.Rows; x++)
            {
                for (int y = 0; y < Weights.Cols; y++)
                {
                    if (Utility.NextDouble() > 0.5)
                        newLayer.Weights.Data[x, y] = partner.Weights.Data[x, y];

                }
                if (Utility.NextDouble() > 0.5)
                    newLayer.Biases.Data[x, 0] = partner.Biases.Data[x, 0];
            }
            return newLayer;
        }

        internal FullyConnected Mutate(double mutationPercentage)
        {
            FullyConnected mutated = Utility<FullyConnected>.DeepClone(this);
            for(int x = 0; x < Weights.Rows; x++)
            {
                for (int y = 0; y < Weights.Cols; y++)
                {
                    if (Utility.NextDouble() <= mutationPercentage)
                        mutated.Weights.Data[x, y] = MathExtension.RandomGaussian(0, 1 / (double)InputCount);
                }
            }
            return mutated;
        }
    }
}
