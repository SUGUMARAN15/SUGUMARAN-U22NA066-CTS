using System;

public class Exercise15
{
    abstract class Vehicle
    {
        public abstract void Drive();
    }

    interface IDrivable
    {
        void Start();
    }

    class Car : Vehicle, IDrivable
    {
        public override void Drive() => Console.WriteLine(""Driving the car"");
        public void Start() => Console.WriteLine(""Starting the car"");
    }

    public static void Main()
    {
        Car car = new Car();
        car.Start();
        car.Drive();

        Vehicle v = car;
        v.Drive();

        IDrivable d = car;
        d.Start();
    }
}
