using System;

namespace ML_Library
{
    /// <summary>A helper class for providing functionality to access different mathematical activation methods</summary>
    public static class Activater
    {
        /// <summary>Activates the matrix with the specified activation method.</summary>
        /// <param name="matrix">The matrix to activate.</param>
        /// <param name="activationMethod">The activation method.</param>
        /// <param name="useDerivative">if set to <c>true</c> [use derivative].</param>
        /// <returns></returns>
        public static Matrix Activate(this Matrix matrix, ActivationMethod activationMethod, bool useDerivative = false)
        {
            if (activationMethod == ActivationMethod.None)
            {
                return matrix;
            }
            Matrix tempMatrix = new Matrix(matrix.Rows, matrix.Cols);
            for (int i = 0; i < matrix.Cols; i++)
            {
                for (int j = 0; j < matrix.Rows; j++)
                {
                    tempMatrix.Data[j, i] = ActivateValue(matrix.Data[j, i], activationMethod, useDerivative);
                }
            }

            return tempMatrix;
        }

        /// <summary>Activates a 2D double array with the specified activation method.</summary>
        /// <param name="array">The 2D double array to activate.</param>
        /// <param name="activationMethod">The activation method.</param>
        /// <param name="useDerivative">if set to <c>true</c> [use derivative].</param>
        /// <returns></returns>
        public static double[,] Activate(this double[,] array, ActivationMethod activationMethod, bool useDerivative = false)
        {
            if (activationMethod == ActivationMethod.None)
            {
                return array;
            }
            double[,] tempArray = new double[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray.GetLength(1); j++)
                {
                    tempArray[i, j] = ActivateValue(array[i, j], activationMethod, useDerivative);
                }
            }

            return tempArray;
        }

        /// <summary>Activates a given value with the specified activation method.</summary>
        /// <param name="x">The value to activate.</param>
        /// <param name="activationMethod">The activation method.</param>
        /// <param name="useDerivative">if set to <c>true</c> [use derivative].</param>
        /// <returns></returns>
        private static double ActivateValue(double x, ActivationMethod activationMethod, bool useDerivative)
        {
            if (useDerivative)
            {
                switch (activationMethod)
                {
                    case ActivationMethod.Sigmoid:
                        return x * (1 - x);
                    case ActivationMethod.Tanh:
                        return 1 - Math.Pow(Math.Tanh(x), 2);
                    case ActivationMethod.Arctan:
                        return 1 / (1 + Math.Pow(x, 2));
                    case ActivationMethod.Gudermannian:
                        return 1 / Math.Cosh(x);
                    default:
                        throw new Exception(activationMethod.ToString() + " is not a valid activation");
                }
            }
            else
            {
                switch (activationMethod)
                {
                    case ActivationMethod.Sigmoid:
                        return 1 / (1 + Math.Exp(-x));
                    case ActivationMethod.Tanh:
                        return Math.Tanh(x);
                    case ActivationMethod.Arctan:
                        return Math.Atan(x);
                    case ActivationMethod.Gudermannian:
                        return 2 * Math.Atan(Math.Tanh(x / 2));
                    default:
                        throw new Exception(activationMethod.ToString() + " is not a valid activation");
                }
            }
        }

        /// <summary>Activates a matrix with the specified inverse activation method.</summary>
        /// <param name="matrix">The matrix to activate with the specified inverse activation method.</param>
        /// <param name="activationMethod">The activation method.</param>
        /// <returns></returns>
        public static Matrix ActivateInverse(this Matrix matrix, ActivationMethod activationMethod)
        {
            Matrix tempMatrix = new Matrix(matrix.Rows, matrix.Cols);
            for (int i = 0; i < matrix.Cols; i++)
            {
                for (int j = 0; j < matrix.Rows; j++)
                {
                    tempMatrix.Data[j, i] = ActivateValueInverse(matrix.Data[j, i], activationMethod);
                }
            }

            return tempMatrix;
        }

        /// <summary>Activates the value with the specified inverse activation method.</summary>
        /// <param name="y">The value to activate with the inverse activation method.</param>
        /// <param name="activationMethod">The activation method.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static double ActivateValueInverse(double y, ActivationMethod activationMethod)
        {
            switch (activationMethod)
            {
                case ActivationMethod.Sigmoid:
                    return Math.Log(y / (1 - y));
                case ActivationMethod.Arctan:
                    return Math.Tan(y);
                default:
                    throw new Exception(activationMethod.ToString() + " is not a valid activation for inverse");
            }
        }
    }
}
