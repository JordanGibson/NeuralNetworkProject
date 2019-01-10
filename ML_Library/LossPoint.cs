using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Library
{
    public class LossPoint
    {
        public double X { get { return TrainingIterations; } }
        public double Y { get { return Loss; } }
        public double Loss { get; set; }
        public double TrainingIterations { get; set; }

        public LossPoint(double loss, double trainingIterations)
        {
            Loss = loss;
            TrainingIterations = trainingIterations;
        }
    }
}
