namespace Lab_2
{
    public class NewtonMethod
    {
        private Func<double, double> function;
        private Func<double, double> firstDerivativeOfFunc;
        private Func<double, double> secondDerivativeOfFunc;
        public double Precision { get; set; } = 0.01;
        public NewtonMethod(Func<double, double> function, Func<double, double> firstDerivativeOfFunc, Func<double, double> secondDerivativeOfFunc)
        {
            this.function = function;
            this.firstDerivativeOfFunc = firstDerivativeOfFunc;
            this.secondDerivativeOfFunc = secondDerivativeOfFunc;
        }
        public NewtonMethod(Func<double, double> function, Func<double, double> firstDerivativeOfFunc, Func<double, double> secondDerivativeOfFunc, double precision) : 
            this(function, firstDerivativeOfFunc, secondDerivativeOfFunc)
        {
            Precision = precision;
        }
        public double Function(double operand)
        {
            return function(operand);
        }
        public double FirstDerivativeOfFunction(double operand)
        {
            return firstDerivativeOfFunc(operand);
        }
        public double SecondDerivativeOfFunction(double operand)
        {
            return secondDerivativeOfFunc(operand);
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
