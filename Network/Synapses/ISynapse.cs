﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Synapses
{
    public interface ISynapse
    {
        double Weight { get; set; }
        double PreviousWeight { get; set; }
        double InputValue { get; set; }
        double GetOutput();

        //bool IsFromNeuron(Guid fromNeuronId);
        void UpdateWeight(double learningRate, double delta);
    }
}
