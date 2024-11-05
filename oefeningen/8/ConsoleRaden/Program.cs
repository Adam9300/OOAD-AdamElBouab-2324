using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            int geheimGetal = 5;
            int gok;
            int poging = 1;
            const int MAX_POGINGEN = 3;
            Console.WriteLine("Raad een getal tussen 1 en 10");
            do
            {
                Console.Write($"Poging {poging}: ");
                gok = Convert.ToInt32(Console.ReadLine());
                poging++;
            } while (gok != geheimGetal && poging <= MAX_POGINGEN);

            Console.WriteLine(geheimGetal == gok ? "Geraden" : "Volgende keer beter");

            Console.ReadKey();
        }
    }
}
