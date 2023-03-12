namespace Lab_2
{
    public class ChordMethod
    {
        private Func<double, double> function;
        public double Precision { get; set; } = 0.01;
        public ChordMethod(Func<double, double> function)
        {
            this.function = function;
        }
        public ChordMethod(Func<double, double> function, double precision) : this(function)
        {
            Precision = precision;
        }
        public double Function(double operand)
        {
            return function(operand);
        }
        public double ChordEquation(double coordinate1, double coordinate2)
        {
            return coordinate1 - ((Function(coordinate1) * (coordinate2 - coordinate1)) / (Function(coordinate2) - Function(coordinate1)));
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
            double x = 0;

            if (Function(ChordEquation(coordinate1, coordinate2)) < 0)
            {
                coordinate1 = ChordEquation(coordinate1, coordinate2);
            }
            else
            {
                coordinate2 = ChordEquation(coordinate1, coordinate2);
            }

            while (true)
            {
                previousX = x;
                x = ChordEquation(coordinate1, coordinate2);

                if (Math.Abs(x - previousX) < Precision)
                {
                    break;
                }
            }

            return x;
        }
    }
}
