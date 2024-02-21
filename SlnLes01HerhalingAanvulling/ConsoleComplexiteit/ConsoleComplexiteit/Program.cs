using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("Geef een woord (enter om te stoppen): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;

            int aantalKarakters = input.Length;
            int aantalLettergrepen = AantalLettergrepen(input);
            double complexiteit = Complexiteit(input);

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
    {
        int aantalLetters = woord.Length;
        int aantalLettergrepen = AantalLettergrepen(woord);

        double complexiteit = aantalLetters / 3.0 + aantalLettergrepen;

        if (woord.Contains('x') || woord.Contains('y') || woord.Contains('q'))
        {
            complexiteit += 1;
        }

        return complexiteit;
    }
}