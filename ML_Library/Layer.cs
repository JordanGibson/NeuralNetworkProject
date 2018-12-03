using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library
{
    public interface Layer
    {
        ActivationMethod ActivationMethod { get; set; }
        double[] Outputs { get; set; }
        int InputCount { get; set; }
        int NodeCount { get; set; }
        double LearningRate { get; set; }

        double[] ForwardPass(double[] inputs);
        double[] Backpropagate(double[] errors);
    }
}
