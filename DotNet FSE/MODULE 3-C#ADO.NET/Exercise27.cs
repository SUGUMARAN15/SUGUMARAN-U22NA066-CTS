using System;
using System.Threading;

public class Exercise27
{
    static object lock1 = new object();
    static object lock2 = new object();

    public static void DeadlockSimulation()
    {
        Thread t1 = new Thread(() =>
        {
            lock (lock1)
            {
                Thread.Sleep(100);
                lock (lock2) { Console.WriteLine(""Thread 1 acquired both locks""); }
            }
        });

        Thread t2 = new Thread(() =>
        {
            lock (lock2)
            {
                Thread.Sleep(100);
                lock (lock1) { Console.WriteLine(""Thread 2 acquired both locks""); }
            }
        });

        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
    }

    public static void DeadlockResolved()
    {
        Thread t1 = new Thread(() =>
        {
            bool lockTaken1 = false;
            bool lockTaken2 = false;
            try
            {
                Monitor.TryEnter(lock1, 1000, ref lockTaken1);
                Monitor.TryEnter(lock2, 1000, ref lockTaken2);

                if (lockTaken1 && lockTaken2)
                    Console.WriteLine(""Thread 1 acquired both locks safely"");
                else
                    Console.WriteLine(""Thread 1 failed to acquire locks"");
            }
            finally
            {
                if (lockTaken1) Monitor.Exit(lock1);
                if (lockTaken2) Monitor.Exit(lock2);
            }
        });

        t1.Start();
        t1.Join();
    }

    public static void Main()
    {
        Console.WriteLine(""Simulating deadlock..."");
        DeadlockResolved();
    }
}
