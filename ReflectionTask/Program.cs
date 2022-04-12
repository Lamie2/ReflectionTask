using System;
using Classes;
namespace ReflectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.ProductCount = 5;
            order1.TotalAmount = 45;
            order1.CreatedAt = "02.02.2022";
            var parsedDate1 = DateTime.Parse(order1.CreatedAt);
            Console.WriteLine(parsedDate1);

            Order order2 = new Order();
            order2.ProductCount = 3;
            order2.TotalAmount = 20;
            order2.CreatedAt = "01.12.2021";
            var parsedDate2 = DateTime.Parse(order2.CreatedAt);
            Console.WriteLine(parsedDate2);

            Order order3 = new Order();
            order3.ProductCount = 12;
            order3.TotalAmount = 200;
            order3.CreatedAt = "01.03.2019";
            var parsedDate3 = DateTime.Parse(order3.CreatedAt);
            Console.WriteLine(parsedDate3);


            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);


            Console.WriteLine($"OrdersAvg: {shop.GetOrdersAvg()}");
           
            Console.WriteLine("FilterOrderByPrice:");
            foreach (var item in shop.FilterOrderByPrice(20,150))
            {
                Console.WriteLine($"No: {item.No}");
            }

            shop.RemoveOrderByNo(2);

        }
    }
}
