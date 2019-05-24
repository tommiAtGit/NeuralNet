using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Activation
{
    public interface IActivationFunction
    {
        double CalculateOutput(double input);
    }
}
