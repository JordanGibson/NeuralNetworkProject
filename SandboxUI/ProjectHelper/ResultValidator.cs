using SandboxUI.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxUI.ProjectHelper
{
    public static class ResultValidator
    {
        public static bool OutputsCorrect(Project project, double[] result, double[] expected)
        {
            switch (project)
            {
                case Project.XOR:
                    if (Math.Round(result[0], 4) == expected[0])
                        return true;
                    return false;
                case Project.MNIST:
                    if(MNISTLoader.GetActualOutputs(result) == MNISTLoader.GetActualOutputs(expected))
                        return true;
                    return false;
                case Project.CIFAR:
                    throw new ArgumentException("Not Implemented");
                default:
                    return false;
            }
        }
    }
}