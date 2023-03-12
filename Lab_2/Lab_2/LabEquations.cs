using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab_2
{
    public static class LabEquations
    {
        public static double Function(double operand)
        {
            return 3 * operand - Math.Cos(operand) - 1;
        }
        public static double FirstDerivativeOfFunction(double operand)
        {
            return 3 + Math.Sin(operand);
        }
        public static double SecondDerivativeOfFunction(double operand)
        {
            return Math.Cos(operand);
        }

        public static double FunctionForIteration(double operand)
        {
            return Math.Pow(operand, 3) - 3 * operand + 1;
        }
        public static double IterationTypeFunction(double operand)
        {
            return (Math.Pow(operand, 3) + 1) / 3;
        }
        public static double FirstDerivativeOfIterationTypeFunction(double operand)
        {
            return Math.Pow(operand, 2) / 3;
        }
    }
}

