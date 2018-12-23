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
        public int[] NodeCounts { get; set; }
        public ActivationMethod[] ActivationMethods { get; set; }

        public Configuration(int networkDepth)
        {
            ActivationMethods = new ActivationMethod[networkDepth];
            NodeCounts = new int[networkDepth];
            LearningRates = new double[networkDepth];
        }
    }
}
