using Lab_1;

double Function(double operand)
{
    return 3 * operand - Math.Cos(operand) - 1;
}

double Function_2(double operand)
{
    return Math.Pow(operand, 3) - 3 * operand + 1;
}

var dihotomia = new Dihotomia(Function);
var dihotomia2 = new Dihotomia(Function_2);

Console.WriteLine(dihotomia.GetSpecifiedRoot());
Console.WriteLine(dihotomia2.GetSpecifiedRoot());

