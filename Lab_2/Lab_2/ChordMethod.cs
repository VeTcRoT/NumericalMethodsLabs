namespace Lab_2
{
    public struct ChordMethod
    {
        private double precision;
        public double Precision
        {
            get { return precision; }
        }

        public ChordMethod()
        {
            precision = 0.01;
        }
        private double Function(double operand)
        {
            return 3 * operand - Math.Cos(operand) - 1;
        }
        private double ChordEquation(double coordinate1, double coordinate2)
        {
            return coordinate1 - ((Function(coordinate1) * (coordinate2 - coordinate1)) / (Function(coordinate2) - Function(coordinate1)));
        }
        private int[] GetCoordinates()
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

                if (Math.Abs(x - previousX) < precision)
                {
                    break;
                }
            }

            return x;
        }
    }
}
