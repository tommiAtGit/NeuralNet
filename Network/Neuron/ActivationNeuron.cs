using NeuralNetwork.Activation;
using NeuralNetwork.Synapses;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Neuron
{
    

    public class ActivationNeuron:Neuron
    {
        protected IActivationFunction ActFunction = null;

        public ActivationNeuron(int inputCount, IActivationFunction activationFunc):base(inputCount)
        {
            this.InputCount = inputCount;
            this.ActFunction = activationFunc;
        }

        public override void Compute()
        {
            double sum = 0;
            if ((Inputs == null) || (Inputs.Count == 0)){
                throw new ArgumentException();
            }
            Inputs.ForEach(Synapse => {
                sum += Synapse.Weight * Synapse.InputValue;
            });
            OutputValue = ActFunction.CalculateOutput(sum);

        }

        public override void UpdateWeight(double learningRate, double delta)
        {
            if ((learningRate == 0)||(delta == 0))
            {
                throw new ArgumentException();
            } 
            Inputs.ForEach(Synapse => {
                Synapse.PreviousWeight = Synapse.Weight;
                Synapse.Weight += learningRate * delta;
            });
            
        }
    }
}