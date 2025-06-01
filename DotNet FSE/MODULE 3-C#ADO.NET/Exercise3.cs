using System;

class Exercise3_PrimaryConstructors
{
    static void Main()
    {
        var person = new Person("John", 30);
        person.DisplayInfo();
    }

    class Person(string Name, int Age)
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
