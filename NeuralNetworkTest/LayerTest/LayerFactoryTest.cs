using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NeuralNetwork.Layer;
using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;
using NeuralNetwork.Synapses;

namespace NeuralNetworkTest.LayerTest
{
    public class LayerFactoryTest
    {
        private const int INPUT_COUNT = 3;
        private const int NETWORK_TYPE_ACTIVATION = 1;
        private const int NETWORK_TYPE_DISTANCE = 2;

        [Fact]
        public void CreateActivationLayerTest()
        {
            
            LayerFactory factory = new LayerFactory();
            IActivationFunction ActivationThresHold = new ThresholdFunction();

            ActivationLayer layer = (ActivationLayer)factory.CreateLayer(NETWORK_TYPE_ACTIVATION, INPUT_COUNT, ActivationThresHold);

            Assert.Equal(3, layer.GetNeuronCount());
            ActivationNeuron actNeuron = (ActivationNeuron) layer.GetNeuron(1);
            Assert.NotNull(actNeuron);

            List<ISynapse> inputs = actNeuron.FetchInputs();
            Assert.NotNull(inputs);
            Assert.Equal(INPUT_COUNT, inputs.Count);

            ISynapse input = inputs[1];
            Assert.True(input.Weight != 0);

            
        }
        [Fact]
        public void CreateDistanceLayerTest()
        {

            LayerFactory factory = new LayerFactory();
            IActivationFunction ActivationThresHold = new ThresholdFunction();

            DistanceLayer layer = (DistanceLayer)factory.CreateLayer(NETWORK_TYPE_DISTANCE, INPUT_COUNT, ActivationThresHold);

            Assert.Equal(3, layer.GetNeuronCount());
            DistanceNeuron actNeuron = (DistanceNeuron)layer.GetNeuron(1);
            Assert.NotNull(actNeuron);

            List<ISynapse> inputs = actNeuron.FetchInputs();
            Assert.NotNull(inputs);
            Assert.Equal(INPUT_COUNT, inputs.Count);

            ISynapse input = inputs[1];
            Assert.True(input.Weight != 0);


        }
    }
}
