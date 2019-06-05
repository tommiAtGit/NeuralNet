using System;
using System.Collections.Generic;
using System.Text;
using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;

namespace NeuralNetwork.Layer
{
    public class DistanceLayer : ILayer
    {
        private List<DistanceNeuron> Neurons = null;

        public DistanceLayer()
        {
            Neurons = new List<DistanceNeuron>();
        }

        public void AddLayer(object neuron)
        {
            DistanceNeuron DistNeuron = (DistanceNeuron)neuron;
            Neurons.Add(DistNeuron);

        }

        public object getLastNeuron()
        {
            throw new NotImplementedException();
        }

        public object GetNeuron(int index)
        {
            if (index >= 0)
            {
                return Neurons[index];
            }
            else
            {
                throw new ArgumentException();
            }
            
        }

        public int GetNeuronCount()
        {
            return Neurons.Count;
        }
    }
}
