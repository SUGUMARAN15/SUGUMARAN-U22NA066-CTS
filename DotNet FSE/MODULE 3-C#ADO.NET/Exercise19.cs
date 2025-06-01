using System;
using System.Collections.Generic;

public class Exercise19
{
    public static void Main()
    {
        List<string> fruits = new List<string> { ""Apple"", ""Banana"", ""Cherry"" };
        Dictionary<int, string> dict = new Dictionary<int, string>
        {
            [1] = ""One"",
            [2] = ""Two"",
            [3] = ""Three""
        };

        Console.WriteLine(""Fruits:"");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(""Dictionary:"");
        foreach (var kvp in dict)
        {
            Console.WriteLine($""{kvp.Key} -> {kvp.Value}"");
        }

        fruits.Add(""Date"");
        dict.Remove(2);

        Console.WriteLine(""After modifications:"");
        Console.WriteLine(""Fruits:"");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine(""Dictionary:"");
        foreach (var kvp in dict)
        {
            Console.WriteLine($""{kvp.Key} -> {kvp.Value}"");
        }
    }
}
