using System;


enum PaymentMethod
{
    Visa,
    Cash,
    Bancontact
}


class Ticket
{
    
    public List<Product> Products { get; }
    public PaymentMethod PaidWith { get; }
    public string Cashier { get; }

    
    public decimal TotalPrice => Products.Sum(p => p.UnitPrice) + (PaidWith == PaymentMethod.Visa ? 0.12m : 0);

    
    public Ticket(List<Product> products, string cashier, PaymentMethod paidWith = PaymentMethod.Cash)
    {
        Products = products;
        PaidWith = paidWith;
        Cashier = cashier;
    }

    
    public void PrintTicket()
    {
        Console.WriteLine("KASSATICKET");
        Console.WriteLine("===========");
        Console.WriteLine($"Uw kassier: {Cashier}\n");
        foreach (var product in Products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("-----------------");
        if (PaidWith == PaymentMethod.Visa)
        {
            Console.WriteLine("Visa kosten: 0,12");
        }
        Console.WriteLine($"Totaal: {TotalPrice:C}");
    }
}
