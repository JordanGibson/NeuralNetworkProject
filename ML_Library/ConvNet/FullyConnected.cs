using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public class FullyConnected : BaseLayer
    {
        public override LayerType LayerType { get { return LayerType.FullyConnected; } }

        public override Matrix3D InputSpace { get; set; }
        public override Matrix3D OutputSpace { get; set; }

        private Matrix3D Weights { get; set; }
        private Matrix3D Biases { get; set; }

        public FullyConnected(int nodeCount)
        {
            
        }

        public override Matrix3D Backpropagate(Matrix3D errors)
        {
            throw new NotImplementedException();
        }

        public override Matrix3D ForwardPropagate(Matrix3D inputSpace)
        {
            InputSpace = inputSpace;
            OutputSpace = new Matrix3D(inputSpace.Rows, inputSpace.Cols, 1);
            return OutputSpace;

        }

        public override void InitialiseLayer(BaseLayer previousLayer)
        {
            throw new NotImplementedException();
        }
    }
}
