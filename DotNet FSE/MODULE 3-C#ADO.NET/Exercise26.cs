using System;
using System.Threading;

public class Exercise26
{
    static int counter = 0;
    static object lockObj = new object();

    public static void Increment()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObj)
            {
                counter++;
            }
        }
    }

    public static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();

        Console.WriteLine($""Counter: {counter}"");
    }
}
