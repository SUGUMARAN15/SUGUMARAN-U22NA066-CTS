using System;
using System.Net;

public class Exercise29
{
    public static void Main()
    {
        Console.Write(""Enter input: "");
        string input = Console.ReadLine();

        string sanitized = WebUtility.HtmlEncode(input);
        Console.WriteLine($""Sanitized input: {sanitized}"");
    }
}
