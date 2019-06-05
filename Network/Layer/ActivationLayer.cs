using System;
using System.Collections.Generic;
using System.Text;
using NeuralNetwork.Activation;
using NeuralNetwork.Neuron;

namespace NeuralNetwork.Layer
{
    public class ActivationLayer:ILayer
    {
        private List<ActivationNeuron> Neurons { get; set; }

        public ActivationLayer()
        {
            Neurons = new List<ActivationNeuron>();
        }

        public void AddLayer(object neuron)
        {
            if (neuron.GetType() != this.GetType())
            {
                //Throw some kind of error here
            }

            ActivationNeuron ActNeuron = (ActivationNeuron)neuron;
            Neurons.Add(ActNeuron);
        }

        public int GetNeuronCount()
        {
            return Neurons.Count;
        }

        public object GetNeuron(int index)
        {
            return Neurons[index];
        }

        public object getLastNeuron()
        {
            throw new NotImplementedException();
        }
    }
}
