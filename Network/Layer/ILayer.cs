using System;
using System.Collections.Generic;
using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;

namespace NeuralNetwork.Layer
{
    public interface ILayer
    {
         void AddLayer(object neuron);
        int GetNeuronCount();
        object GetNeuron(int index);
        object getLastNeuron();

    }
}
