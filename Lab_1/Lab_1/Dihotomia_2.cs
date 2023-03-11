using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    static class Dihotomia_2
    {
        private static double precision = 0.001; 
        private static double Function(double operand)
        {
            double a = Math.Pow(operand, 3) - 3 * operand + 1;
            return a;
        }
        private static int[] GetCoordinates()
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
        public static double GetSpecifiedRoot()
        {
            int[] coordinates = GetCoordinates();
            double a = coordinates[0];
            double b = coordinates[1];
            double x = 0;

            while (true)
            {
                x = (a + b) / 2;

                if (Math.Abs(a - b) < precision)
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
