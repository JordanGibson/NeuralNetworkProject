using Newtonsoft.Json;
using System;

namespace ML_Library
{
    /// <summary>Represents a layer of fully connected nodes in a neural network.</summary>
    [Serializable]
    public class FullyConnected
    {
        [JsonProperty()]
        public ActivationMethod ActivationMethod { get; set; }
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
        public Matrix Biases { get; set; }

        public Matrix Inputs { get; set; }
        public Matrix WeightedSums { get; set; }

        public bool IsInitialized => Weights != null && Biases != null;

        /// <summary>Initializes a new instance of the <see cref="FullyConnected"/> class.</summary>
        /// <param name="nodesInLayer">The number of nodes in the layer.</param>
        /// <param name="activationMethod">The activation method to use on this layer.</param>
        public FullyConnected(int nodesInLayer, ActivationMethod activationMethod)
        {
            NodeCount = nodesInLayer;
            ActivationMethod = activationMethod;
        }

        /// <summary>
        /// Initializes the weights using Xavier Initialization.
        /// </summary>
        /// <param name="inputCount">The input count.</param>
        public void InitializeWeights(int inputCount)
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
        public void InitializeBiases()
        {
            Biases = new Matrix(NodeCount, 1, true);
        }


        /// <summary>
        /// Initializes the weights and biases to random values for this layer.
        /// </summary>
        /// <param name="inputCount">The input count.</param>
        public void InitializeLayer(int inputCount)
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

            WeightedSums = Weights.DotProduct(Inputs).Add(Biases);

            Outputs = WeightedSums.Activate(ActivationMethod).ToArray();

            return Outputs;
        }

        /// <summary>  Performs one iteraiton of backpropagation using the specified errors array through this layer of the network.</summary>
        /// <param name="errorsArr">The errors array.</param>
        /// <returns></returns>
        public double[] Backpropagate(double[] errorsArr)
        {
            Matrix errors = Matrix.FromArray(errorsArr).HardamardProduct(WeightedSums.Activate(ActivationMethod, true));
            double[] nextErrors = Weights.Transpose().DotProduct(errors).ToArray();

            Matrix weightDeltas = Matrix.FromArray(Outputs).Activate(ActivationMethod, true)
                .HardamardProduct(errors)
                .DotProduct(Inputs.Transpose());


            Weights = Weights.Subtract(weightDeltas.ScalarMultiply(LearningRate));
            return nextErrors;
        }
    }
}
