using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    

    class Program
    {
        static void Main(string[] args)
        {
            
            var products = new List<Product>
        {
            new Product("bananen", 1.75m, "P02384"),
            new Product("brood", 2.10m, "P01820"),
            new Product("kaas", 3.99m, "P45612"),
            new Product("koffie", 4.10m, "P98754")
        };

            
            var ticket = new Ticket(products,"Annie",PaymentMethod.Visa);

          
            ticket.PrintTicket();
        }
    }

}
