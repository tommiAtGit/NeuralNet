using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Synapses
{
    class Synapse : ISynapse
    {
        public double Weight { get; set; }
        public double PreviousWeight { get; set; }
        public double InputValue { get; set; }

        public double GetOutput()
        {
            throw new NotImplementedException();
        }

        public void UpdateWeight(double learningRate, double delta)
        {

            if ((learningRate == 0) || (delta == 0))
            {
                throw new ArgumentException();
            }
            PreviousWeight = Weight;
            Weight += learningRate * delta;
            
        }
    }
}
