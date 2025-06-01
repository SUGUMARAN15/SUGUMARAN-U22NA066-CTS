using System;

public class Exercise11
{
    class AccessDemo
    {
        public int publicMember = 1;
        private int privateMember = 2;
        protected int protectedMember = 3;
    }

    class Derived : AccessDemo
    {
        public void Display()
        {
            Console.WriteLine($"Public: {publicMember}");
            // Console.WriteLine($"Private: {privateMember}"); // Not accessible
            Console.WriteLine($"Protected: {protectedMember}");
        }
    }

    class NonDerived
    {
        public void Display()
        {
            AccessDemo obj = new AccessDemo();
            Console.WriteLine($"Public: {obj.publicMember}");
            // Console.WriteLine($"Private: {obj.privateMember}"); // Not accessible
            // Console.WriteLine($"Protected: {obj.protectedMember}"); // Not accessible
        }
    }

    public static void Main()
    {
        Derived d = new Derived();
        d.Display();

        NonDerived nd = new NonDerived();
        nd.Display();
    }
}
