using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public struct IterationMethod
    {
        private double precision;
        public double Precision
        {
            get { return precision; }
        }
        public IterationMethod()
        {
            precision = 0.001;
        }
        private double Function(double operand)
        {
            return Math.Pow(operand, 3) - 3 * operand + 1;
        }
        private double IterationTypeFunction(double operand)
        {
            return (Math.Pow(operand, 3) + 1) / 3;
        }
        private double FirstDerivativeOfIterationTypeFunction(double operand)
        {
            return Math.Pow(operand, 2) / 3;
        }
        private int GetCoordinates(int[] coordinates = null)
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
                GetCoordinates(coordinates);
            }

            return -1;
        }
        public double GetSpecifiedRoot()
        {
            int coordinate = GetCoordinates();

            if (coordinate == -1)
            {
                return -1;
            }

            double previousX = 0;
            double x = coordinate;

            while (true)
            {
                previousX = x;
                x = IterationTypeFunction(x);
                if (Math.Abs(x - previousX) < precision)
                {
                    break;
                }    
            }

            return x;
        }
    }
}
