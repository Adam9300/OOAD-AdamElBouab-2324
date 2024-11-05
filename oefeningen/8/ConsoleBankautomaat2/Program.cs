namespace ConsoleBankautomaat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen
            char keuze;
            int bedrag;
            int saldo = 500;

            // intro tekst
            Console.WriteLine("Bankautomaat");
            Console.WriteLine("============");

            do
            {
                // lees keuze
                Console.WriteLine();
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. stoppen");
                Console.Write("je keuze: ");
                keuze = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                // afhaling
                switch (keuze)
                {
                    case 'a': // afhalen
                        {
                            Console.Write("Welk bedrag wil je afhalen: ");
                            bedrag = Convert.ToInt32(Console.ReadLine());
                            saldo -= bedrag; //saldo = saldo - bedrag
                            Console.WriteLine($"afhaling ok - het nieuw saldo is {saldo}");
                            break;
                        }
                    case 'b': // storten
                        {
                            Console.Write("Welk bedrag wil je storten: ");
                            bedrag = Convert.ToInt32(Console.ReadLine());
                            saldo += bedrag; //saldo = saldo + bedrag
                            Console.WriteLine($"storting ok - het nieuw saldo is {saldo}");
                            break;
                        }
                    case 'c': // stoppen
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ongeldige keuze");
                            break;
                        }
                }
            } while (keuze != 'c');

            Console.WriteLine("Bedankt en tot ziens.");
            Console.ReadKey();
        }
    }
}
