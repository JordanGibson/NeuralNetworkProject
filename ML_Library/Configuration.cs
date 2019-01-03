using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ML_Library
{
    [Serializable]
    public class Configuration
    {
        [JsonProperty()]
        public int InputCount { get; set; }
        [JsonProperty()]
        public double[] LearningRates { get; set; }
        [JsonProperty()]
        public int[] NodeCounts { get; set; }
        [JsonProperty()]
        public ActivationMethod[] ActivationMethods { get; set; }
        
        [JsonConstructor()]
        public Configuration()
        {

        }

        public Configuration(int networkDepth)
        {
            ActivationMethods = new ActivationMethod[networkDepth];
            NodeCounts = new int[networkDepth];
            LearningRates = new double[networkDepth];
        }

        public Configuration Copy()
        {
            return new Configuration(InputCount)
            {
                InputCount = InputCount,
                NodeCounts = NodeCounts,
                ActivationMethods = ActivationMethods,
                LearningRates = LearningRates
            };
        }

        public static bool IsBlank(Configuration configuration)
        {
            if (configuration.NodeCounts == null)
                return true;
            if (configuration.NodeCounts.Length == 0)
                return true;
            return false;
        }
    }
}
