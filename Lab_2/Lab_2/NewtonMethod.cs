namespace Lab_2
{
    public struct NewtonMethod
    {
        public double Precision { get; set; }
        public NewtonMethod()
        {
            Precision = 0.01;
        }
        public NewtonMethod(double precision)
        {
            Precision = precision;
        }
        public double Function(double operand)
        {
            return 3 * operand - Math.Cos(operand) - 1;
        }
        public double FirstDerivativeOfFunction(double operand)
        {
            return 3 + Math.Sin(operand);
        }
        public double SecondDerivativeOfFunction(double operand)
        {
            return Math.Cos(operand);
        }
        public double NewtonMethodFunction(double operand)
        {
            return operand - Function(operand) / FirstDerivativeOfFunction(operand);
        }
        public int[] GetCoordinates()
        {
            int[] coordinates = new int[2];

            for (int i = 0; true; i++)
            {
                if (Function(i) < 0)
                {
                    coordinates[0] = i;
                    break;
                }
            }

            for (int i = 0; true; i++)
            {
                if (Function(i) > 0)
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
            double coordinate1 = coordinates[0];
            double coordinate2 = coordinates[1];

            double previousX = 0;
            double x = Function(coordinate1) * SecondDerivativeOfFunction(coordinate1) > 0 ? coordinate1 : coordinate2;

            while (true)
            {
                previousX = x;
                x = NewtonMethodFunction(x);

                if (Math.Abs(x - previousX) < Precision)
                {
                    break;
                }
            }

            return x;
        }
    }
}
