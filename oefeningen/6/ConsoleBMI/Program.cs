using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");
            
            Console.Write("Lengte (in cm): ");
            double lengte = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gewicht (in kg): ");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            double lengteInMeter = lengte / 100.0;
            double bmi = gewicht / (lengteInMeter * lengteInMeter);

            bmi = Math.Round(bmi, 1);

            Console.WriteLine($"Je BMI bedraagt: {bmi}");
            Console.ReadLine();
        }
    }
}
