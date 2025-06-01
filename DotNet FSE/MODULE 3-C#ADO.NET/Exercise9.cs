using System;

class Exercise9
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine($""Factorial of {number} is {CalculateFactorial(number)}"");
    }

    static int CalculateFactorial(int n)
    {
        int Factorial(int x) // local function
        {
            if (x <= 1) return 1;
            return x * Factorial(x - 1);
        }

        return Factorial(n);
    }
}
