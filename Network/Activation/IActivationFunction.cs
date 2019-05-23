using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Activation
{
    interface IActivationFunction
    {
        double CalculateOutput(double input);
    }
}
