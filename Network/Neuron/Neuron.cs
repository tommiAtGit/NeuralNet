using NeuralNetwork.Synapses;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Neuron
{
    public abstract class Neuron
    {
        protected int InputCount { get; set; }
        protected List<ISynapse> Inputs { get; set;}
        protected double BiasValue { get; set; }
        protected double OutputValue { get; set; }

        public Neuron(int inputCount)
        {
            this.InputCount = inputCount;
            InitWeights();
            InitBiasWeight();

        }

        public abstract double Compute();
        public abstract void UpdateWeight(double learningRate, double delta);
        public abstract void FeedForward(double [] Inputvalues);

        private void InitWeights()
        {
            Inputs = new List<ISynapse>();
            for (int i = 0; i < InputCount; i++)
            {
                ISynapse Input = new Synapse();
                Random random = new Random((int)DateTime.Now.Ticks);
                Input.Weight = random.NextDouble();
                Input.PreviousWeight = 0;
                Inputs.Add(Input);
            }
        }
        private void InitBiasWeight()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            BiasValue = random.NextDouble();
             
        }

    }
}
