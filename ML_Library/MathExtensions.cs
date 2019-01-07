using System;

namespace ML_Library
{
    /// <summary>A helper class for accomplishing various mathematical operations useful in neural networks.</summary>
    public static class MathExtension
    {
        /// <summary>Gets a random value from the gaussian (normal) distribution table according to a given standard deviation and mean</summary>
        /// <param name="mean">The mean.</param>
        /// <param name="stdDev">The standard deviation.</param>
        /// <returns></returns>
        public static double RandomGaussian(double mean = 0, double stdDev = 1)
        {
            double a = 1.0 - Utility.NextDouble(),
                   b = 1.0 - Utility.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(a)) * Math.Sin(2.0 * Math.PI * b);
            return mean + stdDev * randStdNormal;
        }

        /// <summary>Performs elementwise subtraction on two double arrays.</summary>
        /// <param name="thisArray">The array to subtract from.</param>
        /// <param name="array">The array to subtract.</param>
        /// <returns></returns>
        public static double[] ElementwiseSubtract(this double[] thisArray, double[] array)
        {
            double[] tempArr = new double[thisArray.Length];
            for (int i = 0; i < thisArray.Length; i++)
            {
                tempArr[i] = thisArray[i] - array[i];
            }
            return tempArr;
        }

        public static double GetActivationMethodMaxValue(ActivationMethod activationMethod)
        {
            switch (activationMethod)
            {
                case ActivationMethod.Sigmoid:
                case ActivationMethod.Tanh:
                    return 1;
                case ActivationMethod.Arctan:
                case ActivationMethod.Gudermannian:
                    return Math.PI / 2;
                case ActivationMethod.ReLU:
                    return double.PositiveInfinity;
                default:
                    throw new Exception("Invalid Activation Method!");
            }
        }

        public static double GetActivationMethodMinValue(ActivationMethod activationMethod)
        {
            switch (activationMethod)
            {
                case ActivationMethod.Sigmoid:
                case ActivationMethod.ReLU:
                    return 0;
                case ActivationMethod.Tanh:
                    return -1;
                case ActivationMethod.Arctan:
                case ActivationMethod.Gudermannian:
                    return -Math.PI / 2;
                default:
                    throw new Exception("Invalid Activation Method!");
            }
        }

        public static double[] Zeros(int items)
        {
            double[] result = new double[items];
            for (int i = 0; i < items; i++)
            {
                result[i] = 0;
            }
            return result;
        }
    }
}
