using System;

class QuadraticEquationSolver
{
private double a;
private double b;
private double c;
private double discriminant;
private double root1;
private double root2;

public QuadraticEquationSolver(double a, double b, double c)
{
this.a = a;
this.b = b;
this.c = c;
CalculateDiscriminant();
CalculateRoots();
}

private void CalculateDiscriminant()
{
discriminant = b * b - 4 * a * c;
}

private void CalculateRoots()
{
if (discriminant > 0)
{
root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
}
else if (discriminant == 0)
{
root1 = -b / (2 * a);
root2 = root1;
}
// if discriminant < 0, roots are complex numbers, not handled in this example
}

public void DisplayRoots()
{
Console.WriteLine("Root 1: " + root1);
Console.WriteLine("Root 2: " + root2);
}
}

class Program
{
static void Main(string[] args)
{
double a = 1;
double b = -3;
double c = 2;

QuadraticEquationSolver equation1 = new QuadraticEquationSolver(a, b, c);
equation1.DisplayRoots();
}
}