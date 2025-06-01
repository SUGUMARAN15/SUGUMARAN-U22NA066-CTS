using System;
using System.Diagnostics;
using System.IO;

public class Exercise28
{
    public static void Main()
    {
        Trace.Listeners.Add(new TextWriterTraceListener(""log.txt""));
        Trace.Listeners.Add(new ConsoleTraceListener());

        Trace.WriteLine(""Application started."");

        for (int i = 0; i < 3; i++)
        {
            Trace.WriteLine($""Loop index: {i}"");
        }

        Trace.WriteLine(""Application ended."");
        Trace.Flush();
    }
}
