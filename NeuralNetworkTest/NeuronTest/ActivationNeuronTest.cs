using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;
using System;
using Xunit;

namespace NeuralNetworkTest
{
    public class ActivationNeuronTest
    {
        private  readonly double[] InputValues = {0.2,0.7,-0.4};

  

        [Fact]
        public void NeuronInitializeActivationThresHold()
        {
            int InputCount = 3;
            double outputValue = 0;
            IActivationFunction ActivationThresHold = new ThresholdFunction();
            Neuron ActNeuron = new ActivationNeuron(InputCount, ActivationThresHold);
            ActNeuron.FeedForward(InputValues);
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
            ActNeuron.FeedForward(InputValues);
            outputValue = ActNeuron.Compute();

            Assert.True(outputValue != 0);
        }
        [Fact]
        public void NeuronUpdateWeights()
        {
            double learningRate = 0.3;
            double delta = -0.3;

            int InputCount = 3;
            double outputValue = 0;
            double outputAfterUpdate = 0;
            IActivationFunction ActivationSigmoid = new SigmoidFunction();
            Neuron ActNeuron = new ActivationNeuron(InputCount, ActivationSigmoid);
            ActNeuron.FeedForward(InputValues);
            outputValue = ActNeuron.Compute();
            Assert.True(outputValue != 0);

            ActNeuron.UpdateWeight(learningRate, delta);
            outputAfterUpdate = ActNeuron.Compute();
            Assert.NotEqual(outputValue, outputAfterUpdate);


        }

    }
}
