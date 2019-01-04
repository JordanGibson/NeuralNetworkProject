 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public abstract class BaseLayer
    {
        public abstract LayerType LayerType { get; }
        public abstract Matrix3D InputSpace { get; set; }
        public abstract Matrix3D OutputSpace { get; set; }

        public abstract Matrix3D ForwardPropagate(Matrix3D inputSpace);
        public abstract Matrix3D Backpropagate(Matrix3D errors);
    }
}
