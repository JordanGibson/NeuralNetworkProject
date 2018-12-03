using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library
{
    public static class MathExtension
    {
        public static double RandomGaussian(double mean, double stdDev)
        {
            double val1 = 1.0 - Utility.NextDouble();
            double val2 = 1.0 - Utility.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(val1)) * Math.Sin(2.0 * Math.PI * val2);
            return mean + stdDev * randStdNormal;
        }

        public static double RandomGaussian()
        {
            double val1 = 1.0 - Utility.NextDouble();
            double val2 = 1.0 - Utility.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(val1)) * Math.Sin(2.0 * Math.PI * val2);
        }

        public static double[] ElementwiseSubtract(this double[] thisArray, double[] array)
        {
            double[] tempArr = new double[thisArray.Length];
            for (int i = 0; i < thisArray.Length; i++)
            {
                tempArr[i] = thisArray[i] - array[i];
            }
            return tempArr;
        }
    }
}
