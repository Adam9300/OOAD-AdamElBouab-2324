using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een kleine letter: ");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(@"Het nummer is {0}", Convert.ToInt32(c));
            Console.WriteLine(@"De hoofdletter is {0}", Convert.ToChar(c - 32));
            Console.WriteLine(@"De vorige letter is {0}", Convert.ToChar(c - 1));
            Console.WriteLine(@"De volgende letter is {0}", Convert.ToChar(c + 1));
            Console.ReadKey();
        }
    }
}
