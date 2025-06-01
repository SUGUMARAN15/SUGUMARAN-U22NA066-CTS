using System;

class Exercise7
{
    static void Main()
    {
        Console.WriteLine(CalculateTotal(5, 10));             // Two integers
        Console.WriteLine(CalculateTotal(1.5, 2.5, 3.5));    // Three doubles
    }

    static int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    static double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }
}
