using System;
using System.Collections.Generic;
using System.Text;
using NeuralNetwork.Synapses;

namespace NeuralNetwork.Neuron
{
    public class DistanceNeuron:Neuron
    {
        public DistanceNeuron(int inputCount) : base(inputCount)
        {
            this.InputCount = inputCount;
        }

        public override double Compute()
        {
            throw new NotImplementedException();
            
        }

        public override void FeedForward(double[] Inputvalues)
        {
            throw new NotImplementedException();
        }

        public override List<ISynapse> FetchInputs()
        {
            return Inputs;
        }

        public override void UpdateWeight(double learningRate, double delta)
        {
            throw new NotImplementedException();
        }
    }
}
