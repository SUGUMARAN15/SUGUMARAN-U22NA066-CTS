using System;

public class Exercise13
{
    public record Employee(string Name, int Id);

    public static void Main()
    {
        var emp1 = new Employee(""Alice"", 101);
        Console.WriteLine($""Employee: {emp1.Name}, ID: {emp1.Id}"");

        var emp2 = emp1 with { Name = ""Bob"" };
        Console.WriteLine($""Modified Employee: {emp2.Name}, ID: {emp2.Id}"");
        Console.WriteLine($""Original Employee still: {emp1.Name}, ID: {emp1.Id}"");
    }
}
