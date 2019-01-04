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

        public override Matrix3D Backpropagate(Matrix3D errors)
        {
            throw new NotImplementedException();
        }

        public override Matrix3D ForwardPropagate(Matrix3D inputSpace)
        {
            return null;
        }
    }
}
