using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public class Matrix3D
    {
        public Matrix[] Matrices { get; set; }
        public int Rows { get { return Matrices[0].Data.GetLength(0); } }
        public int Cols { get { return Matrices[0].Data.GetLength(1); } }
        public int Depth { get { return Matrices.Length; } }

        public Matrix3D(int rows, int cols, int depth, bool randomize = false)
        {
            Matrices = new Matrix[depth];
            for (int i = 0; i < depth; i++)
            {
                Matrices[i] = new Matrix(rows, cols, randomize);
            }
        }

        public Matrix3D CrossMultiply(Matrix3D matrix)
        {
            Matrix3D tempMatrix = new Matrix3D(Rows, Cols, Depth);

            for (int filter = 0; filter < Depth; filter++)
            {
                for (int x = 0; x < Rows; x++)
                {
                    for (int y = 0; y < Cols; y++)
                    {
                        tempMatrix[filter, x, y] = matrix[filter, x, y] * this[filter, x, y];
                    }
                }
            }
            return tempMatrix;
        }

        public Matrix3D SubMatrix(int xCoord, int yCoord, int size)
        {
            Matrix3D subMatrix = new Matrix3D(size, size, Depth);
            for (int filter = 0; filter < Depth; filter++)
            {
                for (int x = xCoord; x < size + xCoord; x++)
                {
                    for (int y = yCoord; y < size + yCoord; y++)
                    {
                        subMatrix[filter, x - xCoord, y - yCoord] = this[filter, x, y];
                    }
                }
            }
            return subMatrix;
        }

        public static Matrix3D FromBitmap(Bitmap image, bool greyscale)
        {
            Bitmap bmp = new Bitmap(image);
            Matrix3D matrix = new Matrix3D(bmp.Width, bmp.Height, greyscale ? 1 : 3);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    matrix[0, x, y] = (double)bmp.GetPixel(x, y).R / 255;
                    if (!greyscale)
                    {
                        matrix[1, x, y] = (double)bmp.GetPixel(x, y).G / 255;
                        matrix[2, x, y] = (double)bmp.GetPixel(x, y).B / 255;

                    }
                }
            }
            return matrix;
        }

        public double Sum()
        {
            double tempSum = 0;
            for (int filter = 0; filter < Depth; filter++)
            {
                for (int x = 0; x < Rows; x++)
                {
                    for (int y = 0; y < Cols; y++)
                    {
                        tempSum += this[filter, x, y];
                    }
                }
            }
            
            return tempSum;
        }

        public Matrix ToMatrix1D()
        {
            return new Matrix(Rows * Cols * Depth, 1) { Data = this[0].Data };
        }

        public Matrix3D Pad(int padCount, double padValue)
        {
            Matrix3D newMatrix = new Matrix3D(Rows + 2 * padCount, Cols + 2 * padCount, Depth);
            for(int filter = 0; filter < Depth; filter++)
            {
                newMatrix[filter] = Matrices[filter].Pad(padCount, padValue);
            }
            return newMatrix;
        }

        public void WriteMatrix()
        {
            for (int filter = 0; filter < Depth; filter++)
            {
                Matrices[filter].WriteMatrix();
                Console.WriteLine("\n\n\n");
            }
        }

        public double this[int filter, int x, int y] { get {  return Matrices[filter].Data[x, y]; } set { Matrices[filter].Data[x, y] = value; } }
        public Matrix this[int i] { get { return Matrices[i]; } set { Matrices[i] = value; } }
        public IEnumerator<Matrix> GetEnumerator() { return (IEnumerator<Matrix>)Matrices.GetEnumerator(); }
    }
}
