using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Dihotomia
    {
        private Func<double, double> function;
        public double Precision { get; set; } = 0.001;
        public Dihotomia(Func<double, double> function)
        {
            this.function = function;
        }
        public Dihotomia(Func<double, double> function, double precision) :this(function)
        {
            Precision = precision;
        }
        private double Function(double operand)
        {
            return function(operand);
        }
        private int[] GetCoordinates()
        {
            int[] coordinates = new int[2];
            for (int i = 0; true; i++)
            {
                if (Function(i) > 0)
                {
                    coordinates[0] = i;
                    break;
                }
            }
            for (int i = 0; true; i++)
            {
                if (Function(i) < 0)
                {
                    coordinates[1] = i;
                    break;
                }
            }
            return coordinates;
        }
        public double GetSpecifiedRoot()
        {
            int[] coordinates = GetCoordinates();
            double a = coordinates[0];
            double b = coordinates[1];
            double x = 0;

            while (true)
            {
                x = (a + b) / 2;

                if (Math.Abs(a - b) < Precision)
                    break;

                if (Function(x) > 0)
                    a = x;
                else
                    b = x;
            }

            return x;
        }
    }
}
