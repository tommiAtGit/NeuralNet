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

        public override double Compute()
        {
            double sum = 0;
            if ((Inputs == null) || (Inputs.Count == 0)){
                throw new ArgumentException();
            }
            Inputs.ForEach(Synapse => {
                sum += Synapse.Weight * Synapse.InputValue;
            });
            OutputValue = ActFunction.CalculateOutput(sum);
            return OutputValue;

        }

        public override void FeedForward(double[] Inputvalues)
        {
            int i = 0;
            if (this.InputCount < Inputvalues.Length)
            {
                throw new ArgumentException();
            }
            Inputs.ForEach(Synapse => {
                Synapse.InputValue = Inputvalues[i];
                i++;
            });
        }

        public override void UpdateWeight(double learningRate, double delta)
        {
            Inputs.ForEach(Synapse => {

                Synapse.UpdateWeight(learningRate, delta);
            });
        }
        public double GetOutputValue()
        {
            return OutputValue;
        }

    }
}