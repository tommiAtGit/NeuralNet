using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Activation
{
    class SigmoidFunction : IActivationFunction
    {
       

        public SigmoidFunction(double coeficient)
        {
            
        }
        double IActivationFunction.CalculateOutput(double input)
        {
            return 1 / (1 + Math.Exp(-input));
        }
    }
}
