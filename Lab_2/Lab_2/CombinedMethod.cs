using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    struct CombinedMethod
    {
        private ChordMethod chordMethod;
        private NewtonMethod newtonMethod;
        public double Precision { get; set; }
        public CombinedMethod()
        {
            chordMethod = new ChordMethod();
            newtonMethod = new NewtonMethod();
            Precision = 0.001;
        }
        public CombinedMethod(double precision) : this()
        {
            Precision = precision;
        }
        public double Function(double operand)
        {
            return newtonMethod.Function(operand);
        }
        public double SecondDerivativeOfFunction(double operand)
        {
            return newtonMethod.SecondDerivativeOfFunction(operand);
        }
        public double ChordEquation(double coordinate1, double coordinate2)
        {
            return chordMethod.ChordEquation(coordinate1, coordinate2);
        }
        public double NewtonMethodFunction(double operand)
        {
            return newtonMethod.NewtonMethodFunction(operand);
        }
        public int[] GetCoordinates()
        {
            return newtonMethod.GetCoordinates();
        }
        public double GetSpecifiedRoot()
        {
            int[] coordinates = GetCoordinates();
            double x = 0;
            double c = 0;
            double z = 0;

            if (Function(coordinates[0]) * SecondDerivativeOfFunction(coordinates[1]) > 0)
            {
                x = coordinates[0];
                c = coordinates[1];
            }
            else
            {
                x = coordinates[1];
                c = coordinates[0];
            }

            while (true)
            {
                z = ChordEquation(x, c);
                x = NewtonMethodFunction(x);

                if (Math.Abs(x - z) <= Precision)
                {
                    break;
                }
            }

            return x;
        }
    }
}
