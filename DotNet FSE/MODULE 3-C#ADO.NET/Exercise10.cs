using System;

class Exercise10
{
    static void Main()
    {
        Car car1 = new Car();
        Car car2 = new Car(""Toyota"", ""Camry"", 2020);

        Console.WriteLine(""Car1:"");
        Console.WriteLine($""Make: {car1.Make}, Model: {car1.Model}, Year: {car1.Year}"");

        Console.WriteLine(""Car2:"");
        Console.WriteLine($""Make: {car2.Make}, Model: {car2.Model}, Year: {car2.Year}"");
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car() // default constructor
        {
            Make = ""Unknown"";
            Model = ""Unknown"";
            Year = 0;
        }

        public Car(string make, string model, int year) // parameterized constructor
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
