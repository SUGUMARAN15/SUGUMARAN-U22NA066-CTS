using System;

class Exercise4_TypeInference
{
    static void Main()
    {
        var i = 5;
        var s = "Hello";
        var p = new Person("Jane", 25);

        Console.WriteLine($"Type of i: {i.GetType()}, value: {i}");
        Console.WriteLine($"Type of s: {s.GetType()}, value: {s}");
        Console.WriteLine($"Type of p: {p.GetType()}, value: Name={p.Name}, Age={p.Age}");
    }

    class Person
    {
        public string Name { get; }
        public int Age { get; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
