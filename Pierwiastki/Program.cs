using System;

public class QuadraticEquationSolver
{
    public static void Main()
    {
        Console.WriteLine("Podaj współczynniki a, b i c równania kwadratowego ax^2 + bx + c = 0:");

        Console.Write("Podaj współczynnik a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj współczynnik b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj współczynnik c: ");
        double c = double.Parse(Console.ReadLine());

        var solutions = Solve(a, b, c);

        Console.WriteLine("Rozwiązania równania kwadratowego:");
        foreach (var solution in solutions)
        {
            Console.WriteLine(solution);
        }
    }

    public static double[] Solve(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { x1, x2 };
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return new double[] { x };
        }
        else
        {
            return new double[0]; // Brak rozwiązań
        }
    }
}
