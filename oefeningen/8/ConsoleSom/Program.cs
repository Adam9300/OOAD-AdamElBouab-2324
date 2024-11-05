using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            string invoer;

            do
            {
                Console.Write("Voer een getal in (q om te stoppen): ");
                invoer = Console.ReadLine();

                if (invoer != "q")
                {
                    int getal = Convert.ToInt32(invoer);
                    som += getal; //som = som + getal
                }
            } while (invoer != "q");

            Console.WriteLine($"De som is: {som}");
            Console.ReadLine();
        }
    }
}
