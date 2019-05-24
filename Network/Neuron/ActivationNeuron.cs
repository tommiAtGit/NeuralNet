using NeuralNetwork.Activation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Neuron
{
    

    public class ActivationNeuron:Neuron
    {
        public ActivationNeuron(int inputCount):base(inputCount)
        {
            this.InputCount = inputCount;
        }

        public override double Compute()
        {
            throw new NotImplementedException();
        }
    }
}
