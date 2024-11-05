using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabelen declaraties
            double prijs = 0;
            string soort = "";
            string grootte = "";

            // intro tekst tonen
            Console.WriteLine(@"
PIZZA BESTELLING
================
");

            // keuze menu pizza soort
            Console.Write(@"Kies je pizza:
a) Margherita 8 euro
b) Funghi 10 euro
c) Diabolo 11 euro
>> wat is je keuze? ");

            char keuze1 = Convert.ToChar(Console.ReadLine());
            switch (keuze1)
            {
                case 'a': 
                    prijs += 8; 
                    soort = "Margherita"; 
                    break;
                case 'b': 
                    prijs += 10; 
                    soort = "Funghi"; 
                    break;
                case 'c': 
                    prijs += 11; 
                    soort = "Diabolo";  
                    break;
            }

            // keuze menu grootte
            Console.Write(@"
Kies de grootte: 
a) 15 cm (klein; - 20%)
b) 20 cm (normaal)
c) 25 cm (groot; + 20%)
>> wat is je keuze? ");

            string keuze2 = Console.ReadLine();
            if (keuze2 == "a" || keuze2 == "A")
            {
                prijs *= 0.80;
                grootte = "klein";
            }
            else if (keuze2 == "b" || keuze2 == "B")
            {
                prijs *= 1.0;
                grootte = "normaal";
            }
            else if (keuze2 == "c" || keuze2 == "C")
            {
                prijs *= 1.20;
                grootte = "groot";
            }

            // keuze levering?
            Console.WriteLine("");
            Console.Write("Thuis bezorgen (3 euro extra)? ja/nee: ");
            
            string keuze3 = Console.ReadLine();
            string bezorging;

            if (keuze3 == "ja") {
                prijs += 3;
                bezorging = "thuis bezorgd";
            }
            else
            {
                bezorging = "afgehaald";
            }

            // samenvatting tonen
            Console.WriteLine("");
            Console.WriteLine($"Jouw bestelling: 1 pizza {soort} {grootte}, voor {prijs} euro, {bezorging}");
            Console.ReadKey();
        }
    }
}
