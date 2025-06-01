using System;

class Exercise6
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine(""For loop:"");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 3) continue; // skip number 3
            Console.Write(numbers[i] + "" "");
        }
        Console.WriteLine();

        Console.WriteLine(""Foreach loop:"");
        foreach (int num in numbers)
        {
            if (num == 4) break; // stop at number 4
            Console.Write(num + "" "");
        }
        Console.WriteLine();

        Console.WriteLine(""While loop:"");
        int index = 0;
        while (index < numbers.Length)
        {
            if (numbers[index] == 2) 
            {
                index++;
                continue; // skip number 2
            }
            Console.Write(numbers[index] + "" "");
            index++;
        }
        Console.WriteLine();

        Console.WriteLine(""Do-while loop:"");
        index = 0;
        do
        {
            if (numbers[index] == 5) break; // stop at number 5
            Console.Write(numbers[index] + "" "");
            index++;
        } while (index < numbers.Length);
        Console.WriteLine();
    }
}
