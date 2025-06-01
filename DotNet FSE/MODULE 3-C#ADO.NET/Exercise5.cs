using System;

class Exercise5_GradeCalculation
{
    static void Main()
    {
        Console.Write(""Enter score (0-100): "");
        if (!int.TryParse(Console.ReadLine(), out int score))
        {
            Console.WriteLine(""Invalid input."");
            return;
        }

        string gradeIfElse;
        if (score >= 90) gradeIfElse = ""A"";
        else if (score >= 80) gradeIfElse = ""B"";
        else if (score >= 70) gradeIfElse = ""C"";
        else if (score >= 60) gradeIfElse = ""D"";
        else gradeIfElse = ""F"";

        Console.WriteLine($""Grade using if-else: {gradeIfElse}"");

        string gradeSwitch = score switch
        {
            >= 90 and <= 100 => ""A"",
            >= 80 and < 90 => ""B"",
            >= 70 and < 80 => ""C"",
            >= 60 and < 70 => ""D"",
            >= 0 and < 60 => ""F"",
            _ => ""Invalid score""
        };

        Console.WriteLine($""Grade using switch: {gradeSwitch}"");
    }
}
