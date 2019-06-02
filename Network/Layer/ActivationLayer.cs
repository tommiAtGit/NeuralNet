using System;
using System.Collections.Generic;
using System.Text;
using NeuralNetwork.Neuron;

namespace NeuralNetwork.Layer
{
    class ActivationLayer
    {
        public List<ActivationNeuron> Neurons;

        public ActivationLayer()
        {
            Neurons = new List<ActivationNeuron>();
        }


    }
}
