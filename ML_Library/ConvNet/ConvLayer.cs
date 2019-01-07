using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public class ConvLayer : BaseLayer
    {
        public override LayerType LayerType { get { return LayerType.Convolutional; } }
        public override Matrix3D InputSpace { get; set; }
        public override Matrix3D OutputSpace { get; set; }
        
        public Matrix3D[] Filters { get; private set; }

        public int Padding { get; private set; } = 1;
        public int Stride { get; private set; }
        public int FilterSize { get; private set; }
        private bool IsInitialised { get { return Filters.All(x => x != null); } }
        private int OutputSize { get { return ((InputSpace.Rows - FilterSize + (2 * Padding)) / Stride + 1) % 1 == 0 ? (InputSpace.Rows - FilterSize + (2 * Padding)) / Stride + 1 : throw new Exception("Stride are compatable with input space."); } }
        
        public ConvLayer(int filterCount, int filterSize, int stride)
        {
            Stride = stride;
            Filters = new Matrix3D[filterCount];
            FilterSize = filterSize;
        }

        private void InitializeLayer()
        {
            for (int i = 0; i < Filters.Length; i++)
            {
                Filters[i] = new Matrix3D(FilterSize, FilterSize, InputSpace.Depth, true);
            }
        }

        public override Matrix3D ForwardPropagate(Matrix3D inputSpace)
        {
            InputSpace = inputSpace;
            if (!IsInitialised)
                InitializeLayer();
            Matrix3D paddedInputSpace = InputSpace.Pad(Padding, 0);
            OutputSpace = new Matrix3D(OutputSize, OutputSize, Filters.Length);
            for (int i = 0; i < Filters.Length; i++)
            {
                OutputSpace[i] = Convolve(paddedInputSpace, Filters[i]);
            }
            return OutputSpace;
        }

        public Matrix Convolve(Matrix3D inputSpace, Matrix3D kernel)
        {
            if (kernel.Depth != inputSpace.Depth)
                throw new Exception("Kernel and Input Space have different dimentionality");
            Matrix featureMap = new Matrix(OutputSize, OutputSize);
            for (int x = 0; x < OutputSize; x++)
            {
                for (int y = 0; y < OutputSize; y++)
                {
                    var subMatrix = inputSpace.SubMatrix(x * Stride, y * Stride, FilterSize).CrossMultiply(kernel);
                    featureMap.Data[x, y] = subMatrix.Sum();
                }
            }
            return featureMap;
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
