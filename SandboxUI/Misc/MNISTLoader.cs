using ML_Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxUI.Misc
{
    public static class MNISTLoader
    {
        public static async Task<double[][]> GetImagesAsync(string imagesPath, int start, int count)
        {
            double[][] result = new double[count][];
            using (BinaryReader br = new BinaryReader(new FileStream(imagesPath, FileMode.Open)))
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < count; i++)
                    {
                        byte[] bResult = new byte[784];
                        br.BaseStream.Seek(((start + i) * 784) + 16, SeekOrigin.Begin);
                        br.Read(bResult, 0, 784);
                        result[i] = bResult.Select(o => Convert.ToDouble(o) / 255).ToArray();
                    }
                });
            }
            return result;
        }

        public static double GetActualOutputs(double[] outputs)
        {
            return Array.IndexOf(outputs, outputs.Max());
        }

        public static async Task<double[][]> GetLabelsAsync(string imagesPath, int start, int count)
        {
            double[][] result = new double[count][];
            await Task.Run(() =>
            {
                using (BinaryReader br = new BinaryReader(new FileStream(imagesPath, FileMode.Open)))
                {
                    for (int i = 0; i < count; i++)
                    {
                        byte[] bResult = new byte[1];
                        br.BaseStream.Seek((start + i) + 8, SeekOrigin.Begin);
                        br.Read(bResult, 0, 1);
                        result[i] = MathExtension.Zeros(10);
                        result[i][bResult.Select(o => Convert.ToInt32(o)).First()] = 1;
                    }
                }
            });
            return result;
        }
    }
}
