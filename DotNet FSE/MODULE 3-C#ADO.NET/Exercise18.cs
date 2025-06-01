using System;

public class Exercise18
{
    class Student
    {
        public required string Name { get; set; }
        public required int Id { get; set; }
    }

    public static void Main()
    {
        // Uncommenting the following will cause a compile-time error due to missing required properties
        // var student = new Student();

        var student2 = new Student { Name = ""Tom"", Id = 123 };
        Console.WriteLine($""Student: {student2.Name}, ID: {student2.Id}"");
    }
}
