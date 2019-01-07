using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public class PoolingLayer : BaseLayer
    {
        public override LayerType LayerType { get { return LayerType.Pooling; } }
        public override Matrix3D InputSpace { get; set; }
        public override Matrix3D OutputSpace { get; set; }
        
        public int PoolSize { get; private set; }
        public int Stride { get { return PoolSize; } }

        public PoolingLayer(int poolSize)
        {
            PoolSize = poolSize;
        }

        public override Matrix3D ForwardPropagate(Matrix3D inputSpace)
        {
            InputSpace = inputSpace;
            OutputSpace = new Matrix3D(inputSpace.Rows/ PoolSize, inputSpace.Cols/ PoolSize, inputSpace.Depth);
            for (int i = 0; i < InputSpace.Depth; i++)
            {
                OutputSpace[i] = MaxPooling(InputSpace[i]);
            }
            return OutputSpace;
        }

        private Matrix MaxPooling(Matrix input)
        {
            Matrix pooled = new Matrix(input.Rows / PoolSize, input.Cols / PoolSize);
            for (int i = 0; i < pooled.Rows; i++)
            {
                for (int j = 0; j < pooled.Cols; j++)
                {
                    var subMatrix = input.SubMatrix(i * Stride, j * Stride, PoolSize);
                    pooled.Data[i, j] = subMatrix.Max();
                }
            }
            return pooled;
        }

        public override Matrix3D Backpropagate(Matrix3D errors)
        {
            throw new NotImplementedException();
        }

        public override void InitialiseLayer(BaseLayer previousLayer)
        {
            throw new NotImplementedException();
        }
    }
}
