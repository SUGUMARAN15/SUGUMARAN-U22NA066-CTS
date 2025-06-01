using System;

public class Exercise12
{
    class Product
    {
        public string Name { get; set; }
        private decimal price;

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0) throw new ArgumentException(""Price cannot be negative."");
                price = value;
            }
        }
    }

    public static void Main()
    {
        var prod = new Product { Name = ""Laptop"", Price = 1200m };
        Console.WriteLine($""Product: {prod.Name}, Price: {prod.Price}"");

        try
        {
            prod.Price = -10;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
