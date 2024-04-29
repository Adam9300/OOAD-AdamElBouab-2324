using System;

class Product
{
    
    public string Name { get; }
    public decimal UnitPrice { get; }
    public string Code { get; }

    
    public Product(string name, decimal unitPrice, string code)
    {
        Name = name;
        UnitPrice = unitPrice;
        Code = code;
    }

    
    public static bool ValidateCode(string code)
    {
        return code.Length == 6 && code.StartsWith("P");
    }

    
    public override string ToString()
    {
        return $"({Code}) {Name} {UnitPrice:C}";
    }
}
