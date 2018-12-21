using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library
{
    public class Configuration
    {
        public int InputCount { get; set; }
        public double[] LearningRates { get; set; }
        public int[] LayerCounts { get; set; }
        public ActivationMethod[] ActivationMethods { get; set; }
    }
}
