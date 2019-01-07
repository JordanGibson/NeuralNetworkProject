using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public class FlattenLayer : BaseLayer
    {
        public override LayerType LayerType { get { return LayerType.Flatten; } }

        public override Matrix3D InputSpace { get; set; }
        public override Matrix3D OutputSpace { get; set; }

        public override Matrix3D Backpropagate(Matrix3D errors)
        {
            throw new NotImplementedException();
        }

        public override Matrix3D ForwardPropagate(Matrix3D inputSpace)
        {
            Matrix3D matrix = new Matrix3D(inputSpace.Rows * inputSpace.Cols * inputSpace.Depth, 1, 1);
            for (int filter = 1; filter < inputSpace.Depth; filter++)
            {
                for (int x = 1; x < inputSpace.Rows; x++)
                {
                    for (int y = 1; y < inputSpace.Cols; y++)
                    {
                        inputSpace[filter - 1, x - 1, y - 1] = matrix[0, (filter * x * y) - 1, 0];
                    }
                }
            }
            return matrix;
        }

        public override void InitialiseLayer(BaseLayer previousLayer)
        {
            throw new NotImplementedException();
        }
    }
}
