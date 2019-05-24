using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Activation
{
    class ThresholdFunction : IActivationFunction
    {
        public ThresholdFunction()
        {

        }

        double IActivationFunction.CalculateOutput(double input)
        {
            return (input >= 0) ? 1 : -1;
        }
    }
}
