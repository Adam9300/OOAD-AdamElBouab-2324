using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("Geef een woord (enter om te stoppen): ");
            string woord = Console.ReadLine();

            if (string.IsNullOrEmpty(woord))
                break;

            int aantalKarakters = woord.Length;
            int aantalLettergrepen = AantalLettergrepen(woord);
            double complexiteit = Complexiteit(woord);

            Console.WriteLine($"Aantal karakters: {aantalKarakters}");
            Console.WriteLine($"Aantal lettergrepen: {aantalLettergrepen}");
            Console.WriteLine($"Complexiteit: {complexiteit:F1}");
        }
   
    }

    static bool IsKlinker(char letter)
    {
        switch (Char.ToLower(letter))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }

    static int AantalLettergrepen(string woord)
    {
        int aantalLettergrepen = 0;
        bool vorigeLetterWasKlinker = false;

        foreach (char letter in woord)
        {
            if (IsKlinker(letter))
            {
                if (!vorigeLetterWasKlinker)
                    aantalLettergrepen++;

                vorigeLetterWasKlinker = true;
            }
            else
            {
                vorigeLetterWasKlinker = false;
            }
        }

        return aantalLettergrepen;
    }

    static double Complexiteit(string woord)
    { // sa va calculer la complexiter , on prend la longuer du mots diviser par 3 
        int aantalLetters = woord.Length; 
        int aantalLettergrepen = AantalLettergrepen(woord);

        double complexiteit = aantalLetters / 3.0 + aantalLettergrepen; 

        if (woord.Contains('x') || woord.Contains('y') || woord.Contains('q')) 
        {
            complexiteit += 1; // Si ya une de les letrres metionnees sa rajouter += 1 de complexite.
        }

        return complexiteit;
    }
}