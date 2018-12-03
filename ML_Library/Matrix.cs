using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ML_Library
{
    [Serializable]
    public class Matrix
    {
        public double[,] Data { get; set; }

        public int Rows { get { return Data.GetLength(0); } }
        public int Cols { get { return Data.GetLength(1); } }

        /// <summary>
        /// Create a new matrix with random values between -1 and 1
        /// </summary>
        /// <param name="rows">Number of rows</param>
        /// <param name="cols">Number of columns</param>
        [JsonConstructor()]
        public Matrix(int rows, int cols, bool randomize = false)
        {
            Data = new double[rows, cols];

            if (randomize)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Data[i, j] = Utility.NextDouble() * 2 - 1;
                    }
                }
            }
        }

        /// <summary>
        /// Gets an instance of the current matrix 
        /// </summary>
        /// <returns></returns>
        public Matrix Copy()
        {
            Matrix tempMatrix = new Matrix(Rows, Cols);
            tempMatrix.Data = Data;
            return tempMatrix;
        }


        /// <summary>
        /// Add a single scalar value to all values in matrix
        /// </summary>
        /// <param name="x">Scalar value to be added</param>
        public Matrix Add(double x)
        {
            Matrix tempMatrix = new Matrix(Rows, Cols);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    tempMatrix.Data[i, j] = Data[i, j] + x;
                }
            }
            return tempMatrix;
        }

        /// <summary>
        /// Creates a Matrix from a single dimensional double array
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Matrix from double array</returns>
        public static Matrix FromArray(double[] array)
        {
            Matrix tempMatrix = new Matrix(array.Length, 1);
            for (int i = 0; i < array.Length; i++)
            {
                tempMatrix.Data[i, 0] = array[i];
            }
            return tempMatrix;
        }


        /// <summary>
        /// Froms the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static Matrix FromArray(double[,] array)
        {
            Matrix tempMatrix = new Matrix(array.GetLength(0), array.GetLength(1));
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempMatrix.Data[i, j] = array[i, j];
                }
            }
            return tempMatrix;
        }


        /// <summary>
        /// Adds the specified Matrix x to this matrix.
        /// </summary>
        /// <param name="x">The x.</param>
        public Matrix Add(Matrix x)
        {
            if (x.Rows != Rows || x.Cols != Cols)
            {
                throw new ArgumentException("Cannot add matrices with different dimensions");
            }
            Matrix tempMatrix = new Matrix(Rows, Cols);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    tempMatrix.Data[i, j] = Data[i, j] + x.Data[i, j];
                }
            }
            return tempMatrix;
        }

        /// <summary>
        /// Elementwise subtraction of b from a
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="subtractor">The b.</param>
        /// <returns></returns>
        public Matrix Subtract(Matrix subtractor)
        {
            if (subtractor.Rows != Rows || subtractor.Cols != Cols)
            {
                throw new ArgumentException("Cannot subtract matrices with different dimensions");
            }
            return subtractor.ScalarMultiply(-1).Add(this);
        }

        /// <summary>
        /// Converts the specified matrix to an array.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns></returns>
        public double[] ToArray()
        {
            double[] values = new double[Cols * Rows];
            for (int i = 1; i <= Rows; i++)
            {
                for (int j = 1; j <= Cols; j++)
                {
                    values[(i * j) - 1] = Data[i - 1, j - 1];
                }
            }
            return values;
        }

        /// <summary>
        /// Multiply each item in the matrix by a scalar value
        /// </summary>
        /// <param name="x">Scalar value</param>
        public Matrix ScalarMultiply(double x)
        {
            Matrix tempMatrix = new Matrix(Rows, Cols);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    tempMatrix.Data[i, j] = Data[i, j] * x;
                }
            }
            return tempMatrix;
        }

        /// <summary>
        /// Multiplies this matrix by x elementwise.
        /// </summary>
        /// <param name="x">The x.</param>
        public Matrix CrossMultiply(Matrix x)
        {
            if (x.Rows != Rows || x.Cols != Cols)
            {
                throw new ArgumentException("Cannot cross multiply matrices with different dimensions");
            }
            Matrix tempMatrix = new Matrix(Rows, Cols);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    tempMatrix.Data[i, j] = Data[i, j] * x.Data[i, j];
                }
            }
            return tempMatrix;
        }

        /// <summary>
        /// //Dot product of Matricies
        /// </summary>
        /// <param name="a">First matrix</param>
        /// <param name="multiplicative">Second matrix</param>
        /// <returns></returns>
        public Matrix DotProduct(Matrix multiplicative)
        {
            if (Cols != multiplicative.Rows)
            {
                throw new ArgumentException("Cols of A must Equal Rows of B");
            }
            Matrix tempMatrix = new Matrix(Rows, multiplicative.Cols);
            double tempSum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int k = 0; k < multiplicative.Cols; k++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        tempSum += Data[i, j] * multiplicative.Data[j, k];
                    }
                    tempMatrix.Data[i, k] = tempSum;
                    tempSum = 0;
                }
            }
            return tempMatrix;
        }

        /// <summary>
        /// Change all rows of matrix to columns and all columns to rows
        //  and return as a new matrix
        /// </summary>
        /// <param name="a">Input matrix</param>
        /// <returns>Matrix as a row</returns>
        public Matrix Transpose()
        {
            Matrix tempMatrix = new Matrix(Cols, Rows);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    tempMatrix.Data[j, i] = Data[i, j];
                }
            }
            return tempMatrix;
        }
    }
}
