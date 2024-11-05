using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot lancering? ");
            int seconden = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(1000); // handig trucje om 1 seconde te pauzeren tot het volgend statement
            for (int i = seconden; i > 0; i--) {
                Console.WriteLine(i + "...");
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Lift off!");
            Console.ReadKey();
        }
    }
}
