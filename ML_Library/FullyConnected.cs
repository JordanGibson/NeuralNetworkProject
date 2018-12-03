using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ML_Library
{
    [Serializable]
    public class FullyConnected : Layer
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
        private Matrix Weights { get; set; }
        [JsonProperty()]
        private Matrix Biases { get; set; }

        private double[] Inputs { get; set; }

        private bool IsInitialized { get { return (Weights != null && Biases != null); } }

        public FullyConnected(int nodesInLayer, ActivationMethod activationMethod)
        {
            NodeCount = nodesInLayer;
            ActivationMethod = activationMethod;
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
            Inputs = inputArr;

            if (!IsInitialized)
            {
                InitializeLayer(Inputs.Length);
            }

            Outputs = Weights.DotProduct(Matrix.FromArray(Inputs))
                .Add(Biases)
                .Activate(ActivationMethod).ToArray();

            return Outputs;
        }

        public double[] Backpropagate(double[] errorsArr)
        {
            Matrix errors = Matrix.FromArray(errorsArr);
            double[] nextErrors = Weights.Transpose().DotProduct(errors).ToArray();

            var gradients = Matrix.FromArray(Outputs);
            gradients = gradients.Activate(ActivationMethod, true);
            gradients = gradients.CrossMultiply(errors);
            gradients = gradients.ScalarMultiply(LearningRate);

            Biases = Biases.Add(gradients);

            var weightDeltas = gradients.DotProduct(Matrix.FromArray(Inputs).Transpose());
            Weights = Weights.Add(weightDeltas);
            return nextErrors;
        }
    }
}
