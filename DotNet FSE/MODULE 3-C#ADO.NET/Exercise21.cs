using System;

public class Exercise21
{
    public static void Describe(object obj)
    {
        switch (obj)
        {
            case int i:
                Console.WriteLine($""Integer: {i}"");
                break;
            case string s:
                Console.WriteLine($""String: {s}"");
                break;
            case null:
                Console.WriteLine(""Null object"");
                break;
            default:
                Console.WriteLine(""Unknown type"");
                break;
        }
    }

    public static void Main()
    {
        Describe(42);
        Describe(""Hello"");
        Describe(null);
    }
}
