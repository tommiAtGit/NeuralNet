using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;
using System;
using Xunit;

namespace NeuralNetworkTest
{
    public class ActivationNeuronTest
    {
        [Fact]
        public void NeuronInitialize()
        {
            int InputCount = 3;
            IActivationFunction ActivationThresHold = new ThresholdFunction();
            Neuron ActNeuron = new ActivationNeuron(InputCount, ActivationThresHold);
            ActNeuron.Compute();
            


        }
    }
}
