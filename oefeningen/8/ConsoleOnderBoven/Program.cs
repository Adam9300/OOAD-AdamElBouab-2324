using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnderBoven
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabelen declareren
            int ondergrens;
            int bovengrens;

            // ondergrens inlezen
            Console.Write("Geef een ondergrens: ");
            ondergrens = Convert.ToInt32(Console.ReadLine());

            // bovengrens inlezen
            Console.Write("Geef een bovengrens: ");
            do
            {
                bovengrens = Convert.ToInt32(Console.ReadLine());
                if (ondergrens == bovengrens)
                {
                    Console.Write("Bovengrens mag niet gelijk zijn aan ondergrens. Geef een bovengrens: ");
                }
                else if (bovengrens < ondergrens)
                {
                    Console.Write("Bovengrens mag niet kleiner zijn dan ondergrens. Geef een bovengrens: ");
                }
            } while (bovengrens <= ondergrens); 

            // bereik weergeven
            Console.Write($"Bereik: van {ondergrens} tot {bovengrens}");
            Console.ReadKey();
        }
    }
}
