using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Layer
{
    

    public class LayerFactory
    {
        private const int TYPE_ACTIVATION = 1;
        private const int TYPE_DISTANCE = 2;
        public ILayer CreateLayer(int type, int numberOfNeurons, IActivationFunction activationFunction)
        {
            ILayer layer = null;
            switch (type)
            {
                case TYPE_ACTIVATION:
                    layer = new ActivationLayer();
                    for (int i = 0; i < numberOfNeurons; i++)
                    {
                        var neuron = new ActivationNeuron(numberOfNeurons, activationFunction);
                        layer.AddLayer(neuron);
                    }
                    break;
                case TYPE_DISTANCE:
                    layer = new DistanceLayer();
                    for(int i = 0; i < numberOfNeurons; i++)
                    {
                        var neuron = new DistanceNeuron(numberOfNeurons);
                        layer.AddLayer(neuron);
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
            

            return layer;
        }
    }
}
