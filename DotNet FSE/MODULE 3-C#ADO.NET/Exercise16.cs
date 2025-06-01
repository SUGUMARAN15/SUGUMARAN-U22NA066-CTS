using System;

public class Exercise16
{
    class Person
    {
        public string? Name { get; set; }
    }

    public static void Main()
    {
        Person? person = null;

        // Null-conditional operator
        Console.WriteLine(person?.Name ?? ""Name is null"");

        person = new Person { Name = ""John"" };
        Console.WriteLine(person?.Name ?? ""Name is null"");
    }
}
