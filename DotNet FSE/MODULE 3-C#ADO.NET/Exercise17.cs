using System;

public class Exercise17
{
    class Contact
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }

    public static void Main()
    {
        Contact? contact = null;

        Console.WriteLine(contact?.Name ?? ""Contact or Name is null"");

        contact = new Contact { Name = ""Alice"", PhoneNumber = ""123456789"" };
        Console.WriteLine(contact?.Name ?? ""Contact or Name is null"");
    }
}
