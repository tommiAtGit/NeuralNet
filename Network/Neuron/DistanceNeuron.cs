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

        public override double Compute()
        {
            throw new NotImplementedException();
        }
    }
}
