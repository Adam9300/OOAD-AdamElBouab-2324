using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabelen
            char keuze;
            int bedrag;
            int saldo = 500;

            // intro tekst
            Console.WriteLine("Bankautomaat");
            Console.WriteLine("============");

            do
            {
                // lees keuze
                Console.WriteLine();
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. stoppen");
                Console.Write("je keuze: ");
                keuze = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                // afhaling 
                if (keuze == 'a')
                {
                    Console.Write("Welk bedrag wil je afhalen: ");
                    bedrag = Convert.ToInt32(Console.ReadLine());
                    saldo -= bedrag; //saldo = saldo - bedrag
                    Console.WriteLine($"afhaling ok - het nieuw saldo is {saldo}");
                }

                else if (keuze == 'b') // storting 
                {
                    Console.Write("Welk bedrag wil je storten: ");
                    bedrag = Convert.ToInt32(Console.ReadLine());
                    saldo += bedrag; //saldo = saldo + bedrag
                    Console.WriteLine($"storting ok - het nieuw saldo is {saldo}");
                }
                else if (keuze != 'c') // ongeldig
                {
                    Console.WriteLine("Ongeldige keuze");
                }
            } while (keuze != 'c');

            Console.WriteLine("Bedankt en tot ziens.");
            Console.ReadKey();
        }
    }
}
