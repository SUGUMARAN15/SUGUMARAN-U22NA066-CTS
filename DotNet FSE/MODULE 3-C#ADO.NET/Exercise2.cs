using System;

class Exercise2_ValueVsReferenceTypes
{
    static void Main()
    {
        int val = 10;
        string str = "Original";

        Console.WriteLine($"Before modification: val = {val}, str = {str}");

        ModifyValue(val);
        ModifyReference(str);

        Console.WriteLine($"After modification: val = {val}, str = {str}");

        PersonClass p = new PersonClass { Name = "Alice" };
        Console.WriteLine($"Before modification: Person.Name = {p.Name}");
        ModifyPerson(p);
        Console.WriteLine($"After modification: Person.Name = {p.Name}");
    }

    static void ModifyValue(int x)
    {
        x = 99;
    }

    static void ModifyReference(string s)
    {
        s = "Modified";
    }

    static void ModifyPerson(PersonClass person)
    {
        person.Name = "Bob";
    }

    class PersonClass
    {
        public string Name { get; set; }
    }
}
