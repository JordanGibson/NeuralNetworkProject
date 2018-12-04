using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library
{
    public static class MathExtension
    {
        public static double RandomGaussian(double mean = 0, double stdDev = 1)
        {
            double a = 1.0 - Utility.NextDouble();
            double b = 1.0 - Utility.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(a)) * Math.Sin(2.0 * Math.PI * b);
            return mean + stdDev * randStdNormal;
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
