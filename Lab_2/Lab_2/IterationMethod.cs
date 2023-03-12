using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public struct IterationMethod
    {
        public double Precision { get; set; }
        public IterationMethod()
        {
            Precision = 0.001;
        }
        public IterationMethod(double precision)
        {
            Precision = precision;
        }
        public double Function(double operand)
        {
            return Math.Pow(operand, 3) - 3 * operand + 1;
        }
        public double IterationTypeFunction(double operand)
        {
            return (Math.Pow(operand, 3) + 1) / 3;
        }
        public double FirstDerivativeOfIterationTypeFunction(double operand)
        {
            return Math.Pow(operand, 2) / 3;
        }
        public int GetFixedPoint(int[] coordinates = null)
        {
            if (coordinates == null)
            {
                coordinates = new int[2];
            }

            for (int i = coordinates[0]; true; i++)
            {
                if (Function(i) < 0)
                {
                    coordinates[0] = i;
                    break;
                }
            }

            for (int i = coordinates[1]; true; i++)
            {
                if (Function(i) > 0)
                {
                    coordinates[1] = i;
                    break;
                }
            }

            if (IterationTypeFunction(coordinates[0]) < 1)
            {
                return coordinates[0];
            }
            else if (IterationTypeFunction(coordinates[1]) < 1)
            {
                return coordinates[1];
            }
            else
            {
                GetFixedPoint(coordinates);
            }

            return -1;
        }
        public double GetSpecifiedRoot()
        {
            int fixedPoint = GetFixedPoint();

            if (fixedPoint == -1)
            {
                return -1;
            }

            double previousX = 0;
            double x = fixedPoint;

            while (true)
            {
                previousX = x;
                x = IterationTypeFunction(x);
                if (Math.Abs(x - previousX) < Precision)
                {
                    break;
                }    
            }

            return x;
        }
    }
}
