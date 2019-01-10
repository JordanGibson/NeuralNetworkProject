using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils = ML_Library.Utility;

namespace SandboxUI.Misc
{
    public static class XORLoader
    {
        public static async Task<Tuple<double[][], double[][]>> GetTrainingDataAsync(int count)
        {
            double[][] rawInputs = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            double[][] rawExpected = new double[][] { new double[] { 0 }, new double[] { 1 }, new double[] { 1 }, new double[] { 0 } };

            double[][] Inputs = new double[count][];
            double[][] Expected = new double[count][];
            for (int i = 0; i < count; i++)
            {

                await Task.Run(() =>
                {
                    int index = Utils.Next(0, 4);
                    Inputs[i] = rawInputs[index];
                    Expected[i] = rawExpected[index];
                });
            }
            return new Tuple<double[][], double[][]>(Inputs, Expected);
        }
    }
}
