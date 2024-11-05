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
            int getal = 3;
            Console.Write("Raad een getal tussen 1 en 10: ");
            int gok = Convert.ToInt32(Console.ReadLine());
            if (gok > getal)
            {
                Console.WriteLine("De gok was te hoog");
            }
            else if (gok < getal)
            {
                Console.WriteLine("De gok was te laag");
            }
            else
            {
                Console.WriteLine("Geraden!");
            }
            Console.ReadKey();
        }
    }
}
