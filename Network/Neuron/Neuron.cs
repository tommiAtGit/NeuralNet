using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Neuron
{
    public abstract class Neuron
    {
        protected int InputCount { get; set; }
        protected List<double> InputValues { get; set; }
        protected List<double> WeightValues { get; set; }
        protected double BiasValue { get; set; }
        protected double OutputValue { get; set; }

        public Neuron(int inputCount)
        {
            this.InputCount = inputCount;
            InitBiasWeight();
            InitBiasWeight();
        }

        public abstract double Compute();

        private void InitWeights()
        {
            WeightValues = new List<double>();
            for (int i = 0; i < InputCount; i++)
            {
                Random random = new Random((int)DateTime.Now.Ticks);
                double weight =  random.NextDouble();
                WeightValues.Add(weight);
            }
        }
        private void InitBiasWeight()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            BiasValue = random.NextDouble();
             
        }

    }
}
