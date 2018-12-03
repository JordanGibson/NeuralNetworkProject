using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library
{
    public static class Activater
    {
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

        private static double ActivateValue(double x, ActivationMethod activationMethod, bool useDerivative)
        {
            if (useDerivative)
            {
                switch (activationMethod)
                {
                    case ActivationMethod.Sigmoid:
                        return x * (1 - x);
                    case ActivationMethod.reLU:
                        return x >= 0 ? 1 : 0;
                    case ActivationMethod.Tanh:
                        return 1 - (Math.Pow(Math.Tanh(x), 2));
                    case ActivationMethod.Arctan:
                        return 1 / (1 + Math.Pow(x, 2));
                    case ActivationMethod.Gudermannian:
                        return 1 / Math.Cosh(x);
                    case ActivationMethod.LreLU:
                        return x >= 0 ? 1 : 0.1;
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
                    case ActivationMethod.reLU:
                        return x > 0 ? x : 0;
                    case ActivationMethod.Tanh:
                        return Math.Tanh(x);
                    case ActivationMethod.Arctan:
                        return Math.Atan(x);
                    case ActivationMethod.Gudermannian:
                        return (2 * Math.Atan(Math.Tanh(x / 2)));
                    case ActivationMethod.LreLU:
                        return x >= 0 ? x : 0.1 * x;
                    default:
                        throw new Exception(activationMethod.ToString() + " is not a valid activation");
                }
            }
        }

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
