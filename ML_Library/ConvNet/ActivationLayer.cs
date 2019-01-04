using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library.ConvNet
{
    public class ActivationLayer : BaseLayer
    {
        public ActivationMethod ActivationMethod;

        public override LayerType LayerType { get { return LayerType.Activation; } }
        public override Matrix3D InputSpace { get; set; }
        public override Matrix3D OutputSpace { get; set; }

        public ActivationLayer(ActivationMethod activationMethod)
        {
            ActivationMethod = activationMethod;
        }

        public override Matrix3D ForwardPropagate(Matrix3D inputSpace)
        {
            InputSpace = inputSpace;
            OutputSpace = new Matrix3D(inputSpace.Rows, inputSpace.Cols, inputSpace.Depth);
            for (int i = 0; i < OutputSpace.Depth; i++)
            {
                OutputSpace[i] = InputSpace[i].Activate(ActivationMethod);
            }
            return OutputSpace;
        }

        public override Matrix3D Backpropagate(Matrix3D errors)
        {
            throw new NotImplementedException();
        }
    }
}
