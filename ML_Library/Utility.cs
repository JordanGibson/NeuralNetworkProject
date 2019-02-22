using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ML_Library
{
    /// <summary>A helper class for performing miscellaneous tasks</summary>
    public static class Utility
    {
        private static Random rand { get; } = new Random();
        
        /// <summary>Get's the next random number in the given range</summary>
        /// <param name="lower">The lower bound</param>
        /// <param name="upper">The upper bound</param>
        public static int Next(int lower, int upper)
        {
            return rand.Next(lower, upper);
        }

        /// <summary>Get's the next random decimal value between 0 and 1</summary>
        public static double NextDouble()
        {
            return rand.NextDouble();
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

        public static double[] Clamp(double[] values, double min, double max)
        {
            double[] newValues = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                newValues[i] = Clamp(values[i], min, max);
            }
            return newValues;
        }
    }

    public static class Utility<T>
    {
        //Found on stackoverflow, used for cloning objects
        public static T DeepClone(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
