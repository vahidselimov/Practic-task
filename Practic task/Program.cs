using Newtonsoft.Json;
using Practic_task.Models;
using System;

namespace Practic_task
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Computer computer = new Computer { Id = 1, Brand = "Asus", Ram = "16GB", GraficCard = "RTX", Price = 2359.00 };
            Computer computer1 = new Computer { Id = 1, Brand = "Lenova", Ram = "8GB", GraficCard = "RTX", Price = 1500.00 };
            Computer computer2 = new Computer { Id = 1, Brand = "HP", Ram = "16GB", GraficCard = "RTX", Price = 2100.00 };
            Computer computer3 = new Computer { Id = 1, Brand = "ACER", Ram = "8GB", GraficCard = "RTX", Price = 1200.00 };


            OrderItem orderItem = new OrderItem { Id = 1, Computer = computer, Price = computer.Price };
            OrderItem orderItem1 = new OrderItem { Id = 2, Computer = computer1, Price = computer.Price };
            OrderItem orderItem2= new OrderItem { Id = 3, Computer = computer, Price = computer.Price };
            OrderItem orderItem3 = new OrderItem { Id = 4, Computer = computer, Price = computer.Price };



            Order order = new Order
            {
                Id = 1,
                orderItems = new System.Collections.Generic.List<OrderItem>()
            {
                orderItem,
                orderItem1,
                orderItem2,
                orderItem3
            },
                Totalprice = 12500.50
            };

            var orderStr = JsonConvert.SerializeObject(order);

        }
    }
}