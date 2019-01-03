using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxUI.ProjectHelper
{
    public class ProjectSettings
    {
        public int InputCount { get; set; }
        public int OutputCount { get; set; }
        public string Name { get; set; }
        public double OutputStartRange { get; set; }
        public double OutputEndRange { get; set; }

        public ProjectSettings(int inputCount, int outputCount, double outputStartRange, double outputEndRange, string name)
        {
            InputCount = inputCount;
            OutputCount = outputCount;
            OutputStartRange = outputStartRange;
            OutputEndRange = outputEndRange;
            Name = name;
        }

        public static ProjectSettings GetSettings(Project project)
        {
            switch (project)
            {
                case Project.XOR:
                    return new ProjectSettings(2, 1, 0, 1, "XOR");
                case Project.MNIST:
                    return new ProjectSettings(728, 10, 0, 1, "MNIST");
                case Project.CIFAR:
                    return new ProjectSettings(1024, 10, 0, 1, "CIFAR");
                default:
                    throw new Exception("Unacceptable project settings.");
            }
        }
    }
}