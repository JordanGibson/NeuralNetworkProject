using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxUI.ProjectHelper
{
    public class ProjectSettings
    {
        public int InputCount { get; private set; }
        public int OutputCount { get; private set; }
        public string Name { get; private set; }

        private ProjectSettings(int inputCount, int outputCount, string name)
        {
            InputCount = inputCount;
            OutputCount = outputCount;
            Name = name;
        }

        public static ProjectSettings GetSettings(Project project)
        {
            switch (project)
            {
                case Project.XOR:
                    return new ProjectSettings(2, 1, "XOR");
                case Project.MNIST:
                    return new ProjectSettings(784, 10, "MNIST");
                case Project.CIFAR:
                    return new ProjectSettings(1024, 10, "CIFAR");
                default:
                    throw new Exception("Unacceptable project settings.");
            }
        }
    }
}