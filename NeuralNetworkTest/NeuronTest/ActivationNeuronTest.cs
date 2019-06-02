using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;
using System;
using Xunit;

namespace NeuralNetworkTest
{
    public class ActivationNeuronTest
    {
        [Fact]
        public void NeuronInitializeActivationThresHold()
        {
            int InputCount = 3;
            double outputValue = 0;
            IActivationFunction ActivationThresHold = new ThresholdFunction();
            Neuron ActNeuron = new ActivationNeuron(InputCount, ActivationThresHold);
            outputValue = ActNeuron.Compute();

            Assert.True(outputValue != 0);
 
        }
        [Fact]
        public void NeuronInitalizeActivationSigmoid()
        {
            int InputCount = 3;
            double outputValue = 0;
            IActivationFunction ActivationSigmoid = new SigmoidFunction();
            Neuron ActNeuron = new ActivationNeuron(InputCount, ActivationSigmoid);
            outputValue = ActNeuron.Compute();

            Assert.True(outputValue != 0);
        }

    }
}
