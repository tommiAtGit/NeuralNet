using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Neuron
{
    class DistanceNeuron:Neuron
    {
        public DistanceNeuron(int inputCount) : base(inputCount)
        {
            this.InputCount = inputCount;
        }

        public override void Compute()
        {
            throw new NotImplementedException();
            
        }

        public override void UpdateWeight(double learningRate, double delta)
        {
            throw new NotImplementedException();
        }
    }
}
