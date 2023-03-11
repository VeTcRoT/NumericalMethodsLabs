using Lab_2;

var chordMethod = new ChordMethod();

var newtonMethod = new NewtonMethod();

var iterationMethod = new IterationMethod();

Console.WriteLine("\n{0}Task 1{1}\n", new string('-', 20), new string('-', 20));

Console.WriteLine("Precision for Chord Method: " + chordMethod.Precision);
Console.WriteLine("Precision for Newton Method: " + newtonMethod.Precision);

Console.WriteLine("\nResult for Chord Method: " + chordMethod.GetSpecifiedRoot());
Console.WriteLine("Result for Newton Method: " + newtonMethod.GetSpecifiedRoot());

Console.WriteLine("\n{0}Task 2{1}\n", new string('-', 20), new string('-', 20));

Console.WriteLine("Precision for Iteration Method: " + iterationMethod.Precision);
Console.WriteLine("\nResult for Iteration Method: " + iterationMethod.GetSpecifiedRoot());