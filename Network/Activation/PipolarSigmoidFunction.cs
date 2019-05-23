using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork.Activation
{
    class PipolarSigmoidFunction : IActivationFunction
    {
        private double _coeficient;

        public PipolarSigmoidFunction(double coeficient)
        {
            _coeficient = coeficient;
        }
        public double CalculateOutput(double input)
        {
            return (1 / (1 + Math.Exp(-input * _coeficient)));
        }
    }
}
