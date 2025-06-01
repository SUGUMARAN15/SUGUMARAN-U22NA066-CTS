using System;

class Exercise8
{
    static void Main()
    {
        int a = 5;
        int b;
        int c = 10;

        Console.WriteLine($""Before ref call: a = {a}"");
        RefMethod(ref a);
        Console.WriteLine($""After ref call: a = {a}"");

        OutMethod(out b);
        Console.WriteLine($""After out call: b = {b}"");

        Console.WriteLine($""Before in call: c = {c}"");
        InMethod(in c);
        Console.WriteLine($""After in call: c = {c}"");
    }

    static void RefMethod(ref int x)
    {
        x = x + 10;
    }

    static void OutMethod(out int x)
    {
        x = 20;
    }

    static void InMethod(in int x)
    {
        // x = x + 10; // Not allowed to modify 'in' parameter
        Console.WriteLine($""Inside in method, value = {x}"");
    }
}
