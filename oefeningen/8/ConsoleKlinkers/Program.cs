using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();
            int aantalKlinkers = 0;
            string geheimeTekst = "";
            foreach (char c in tekst)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
                    aantalKlinkers++;
                }
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') {
                    geheimeTekst += Convert.ToChar(c + 1); //geheimeTekst = geheimeTekst + Convert.ToChar(c + 1)
                } else {
                    geheimeTekst += c;
                }
            }
            Console.WriteLine($"deze tekst bevat {aantalKlinkers} klinkers");
            Console.WriteLine($"in geheimschrift: {geheimeTekst}");
            Console.ReadKey();

        }
    }
}
