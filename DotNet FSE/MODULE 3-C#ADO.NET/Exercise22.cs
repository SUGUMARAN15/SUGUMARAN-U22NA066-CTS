using System;

public class Exercise22
{
    public static (int, string) GetData()
    {
        return (101, ""John"");
    }

    public static void Main()
    {
        var (id, name) = GetData();
        Console.WriteLine($""ID: {id}, Name: {name}"");
    }
}
