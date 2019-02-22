using ML_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GATest
{
    class Program
    {
        static int populationSize = 20;
        static double expected = Math.PI;
        static void Main(string[] args)
        {
            double[] inputs = new double[] { 1, 10, 0.2, 1.3, 4 };
            NeuralNetwork[] population = new NeuralNetwork[populationSize];
            for(int i = 0; i < populationSize; i++)
            {
                population[i] = new NeuralNetwork(5);
                population[i].AddLayer(1);
            }
            for(int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < populationSize; j++)
                {
                    var prediction = population[j].Predict(inputs);
                    population[j].Fitness = Math.Abs(prediction.First() - expected);
                }
                var orderedPopulation = population.OrderBy(o => o.Fitness).ToArray();
                Console.WriteLine("Generation: {0} Best Fitness: {1} Best Approximation: {2}", i, population.Select(o => o.Fitness).Min(), orderedPopulation[0].Structure.Last().Outputs[0]);
                for (int j = 0; j < populationSize; j++)
                {
                    population[j] = orderedPopulation[0].Breed(orderedPopulation[1]);
                }
            }
            Console.ReadLine();
        }
    }
}
