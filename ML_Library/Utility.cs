using System;

namespace ML_Library
{
    /// <summary>A helper class for performing miscellaneous tasks</summary>
    public static class Utility
    {
        private static readonly Random random = new Random();

        /// <summary>Get's the next random number in the given range</summary>
        /// <param name="lower">The lower bound</param>
        /// <param name="upper">The upper bound</param>
        public static int Next(int lower, int upper)
        {
            return random.Next(lower, upper);
        }

        /// <summary>Get's the next random decimal value between 0 and 1</summary>
        public static double NextDouble()
        {
            return random.NextDouble();
        }

        /// <summary>Maps a value from an initial given range to a new given range</summary>
        /// <param name="value">Value to map to new range</param>
        /// <param name="valueStart">The lower bound of the initial values' range</param>
        /// <param name="valueEnd">The upper bound of the initial values' range</param>
        /// <param name="resultStart">The lower bound of the final values' range</param>
        /// <param name="resultEnd">The upper bound of the final values' range</param>
        public static double Map(double value, double valueStart, double valueEnd, double resultStart, double resultEnd)
        {
            return (resultEnd - resultStart) * (value - valueStart) / (valueEnd - valueStart) + resultStart;
        }

        /// <summary>Map values from an initial given range to a new given range</summary>
        /// <param name="values">Values to map to new range</param>
        /// <param name="valueStart">The lower bound of the initial values' range</param>
        /// <param name="valueEnd">The upper bound of the initial values' range</param>
        /// <param name="resultStart">The lower bound of the final values' range</param>
        /// <param name="resultEnd">The upper bound of the final values' range</param>
        public static double[] Map(double[] values, double valueStart, double valueEnd, double resultStart, double resultEnd)
        {
            double[] newValues = new double[values.Length];
            for(int i = 0; i < values.Length; i++)
            {
                newValues[i] = (resultEnd - resultStart) * (values[i] - valueStart) / (valueEnd - valueStart) + resultStart;
            }
            return newValues;
        }

        /// <summary>Ensures a value does not go beyond a given range</summary>
        /// <param name="value">The value to clamp to a range</param>
        /// <param name="min">The minimum number value can take</param>
        /// <param name="max">The maximum number value can take</param>
        public static double Clamp(double value, double min, double max)
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
