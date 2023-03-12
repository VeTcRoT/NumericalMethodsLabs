using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public delegate double Function(double operand);
    public delegate double FirstDerivativeOfFunction(double operand);
    public delegate double SecondDerivativeOfFunction(double operand);
    public delegate double IterationTypeFunction(double operand);
    public delegate double FirstDerivativeOfIterationTypeFunction(double operand);
}
