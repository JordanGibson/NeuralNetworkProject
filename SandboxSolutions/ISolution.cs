using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxSolutions
{
    public interface ISolution
    {
        double CurrentError { get; set; }
        double[] Predict(double[] inputs);
        void Train(int trainingIterations);
    }
}
