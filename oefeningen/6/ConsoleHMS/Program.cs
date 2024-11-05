using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het aantal seconden: ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            int uren = aantal / 3600;
            int rest = aantal % 3600;
            int minuten = rest / 60;
            int seconden = rest % 60;
            Console.Write($"Omgezet in hms formaat: {uren}:{minuten}:{seconden}");
            Console.ReadKey();
        }
    }
}
