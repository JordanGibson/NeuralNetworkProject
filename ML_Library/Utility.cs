using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library
{
    public static class Utility
    {
        private static Random random = new Random();

        public static int Next(int lower, int upper)
        {
            return random.Next(lower, upper);
        }

        public static double NextDouble()
        {
            return random.NextDouble();
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value > max)
            {
                return max;
            }
            else if (value < min)
            {
                return min;
            }
            else
            {
                return value;
            }
        }
    }
}
