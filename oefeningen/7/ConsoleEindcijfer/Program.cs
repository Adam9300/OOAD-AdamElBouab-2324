using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie variabelen
            double cijferDagelijksOp20;
            double cijferProjectOp20;
            double cijferExamenOp20;
            double cijferEindOp20;
            double cijferEindOp100;

            // intro tekst
            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("=====================");
            Console.WriteLine();

            // lees variabelen in
            Console.Write("Geef het cijfer dagelijks werk (op 20): ");
            cijferDagelijksOp20 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het project (op 20): ");
            cijferProjectOp20 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het examen (op 20): ");
            cijferExamenOp20 = Convert.ToDouble(Console.ReadLine());

            // bereken eindcijfer
            cijferEindOp20 = (cijferDagelijksOp20 * 30 + cijferProjectOp20 * 20 + cijferExamenOp20 * 50) / 100;
            if (cijferExamenOp20 < 8)
            {
                cijferEindOp20 = Math.Min(cijferExamenOp20, cijferEindOp20);
            }

            // zet om naar 100 en toon eincijfer
            cijferEindOp100 = cijferEindOp20 * 5;
            Console.WriteLine();
            Console.WriteLine("Je eindcijfer is {0}%", Math.Round(cijferEindOp100, 1));
            Console.WriteLine();

            // toon graad
            if (cijferEindOp100 < 50)
            {
                Console.WriteLine("-> onvoldoende");
            }
            else if (cijferEindOp100 < 67.5)
            {
                Console.WriteLine("-> voldoende");
            }
            else if (cijferEindOp100 < 75)
            {
                Console.WriteLine("-> onderscheiding");
            }
            else if (cijferEindOp100 < 82.5)
            {
                Console.WriteLine("-> grote onderscheiding");
            }
            else
            {
                Console.WriteLine("-> grootste onderscheiding");
            }
            Console.ReadKey();
        }
    }
}
