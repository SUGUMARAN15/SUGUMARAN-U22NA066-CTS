using System;
using System.Collections.Generic;
using System.Linq;

public class Exercise20
{
    class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }
    }

    public static void Main()
    {
        var orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = ""Alice"", TotalAmount = 120.50 },
            new Order { OrderId = 2, CustomerName = ""Bob"", TotalAmount = 75.00 },
            new Order { OrderId = 3, CustomerName = ""Charlie"", TotalAmount = 200.00 }
        };

        var filtered = orders.Where(o => o.TotalAmount > 100)
                             .Select(o => new { o.OrderId, o.CustomerName });

        foreach (var order in filtered)
        {
            Console.WriteLine($""OrderId: {order.OrderId}, Customer: {order.CustomerName}"");
        }
    }
}
