using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Activation
{
    public class SigmoidFunction : IActivationFunction
    {
       
        double IActivationFunction.CalculateOutput(double input)
        {
            return 1 / (1 + Math.Exp(-input));
        }
    }
}
