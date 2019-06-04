using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NeuralNetwork.Layer;
using NeuralNetwork.Activation;

namespace NeuralNetworkTest.LayerTest
{
    public class LayerFactoryTest
    {
        [Fact]
        public void CreateActivationLayerTest()
        {
            
            LayerFactory factory = new LayerFactory();
            IActivationFunction ActivationThresHold = new ThresholdFunction();

            ActivationLayer layer = (ActivationLayer)factory.CreateLayer(1, 3, ActivationThresHold);
            
        }
    }
}
