using System;
using System.Collections.Generic;
using System.Linq;

public enum CardColor
{
    C,
    S,
    H,
    D
}

public class Card
{
    public int Number { get; }
    public CardColor Color { get; }

    public Card(int number, CardColor color)
    {
        if (number < 1 || number > 13)
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 13");

        Number = number;
        Color = color;
    }

    public override string ToString()
    {
        return $"{Number} of {Color}";
    }
}

public class Deck
{
    private List<Card> cards = new List<Card>();

    public List<Card> Cards { get { return cards; } }

    public Deck()
    {
        foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
        {
            for (int number = 1; number <= 13; number++)
            {
                cards.Add(new Card(number, color));
            }
        }
    }

    public void Shuffle()
    {
        Random rng = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public Card DrawCard()
    {
        if (cards.Count == 0)
            throw new InvalidOperationException("ERROR: No Cards In Deck!!");

        Card card = cards.Last();
        cards.Remove(card);
        return card;
    }
}

public class Player
{
    public string Name { get; }
    public List<Card> Cards { get; }
    public int StillCards { get { return Cards.Count; } }

    public Player(string name)
    {
        Name = name;
        Cards = new List<Card>();
    }

    public Player(string name, List<Card> initialCards) : this(name)
    {
        Cards.AddRange(initialCards);
    }

    public Card LayCard()
    {
        if (Cards.Count == 0)
            throw new InvalidOperationException("No cards left to lay");

        Random random = new Random();
        int index = random.Next(0, Cards.Count);
        Card card = Cards[index];
        Cards.RemoveAt(index);
        return card;
    }
}

class Program
{
    static void Main(string[] args)
    {
        const int AANTAL_KAARTEN_HAND = 5;

        Deck deck = new Deck();
        deck.Shuffle();
        Player spelerHans = new Player("Hans");
        Player spelerRogier = new Player("Rogier");
        // deel kaarten uit
        for (int i = 0; i < AANTAL_KAARTEN_HAND; i++)
        {
            spelerHans.Cards.Add(deck.DrawCard());
            spelerRogier.Cards.Add(deck.DrawCard());
        }
        // speel spel
        double puntenHans = 0;
        double puntenRogier = 0;
        while (spelerHans.StillCards > 0 && spelerRogier.StillCards > 0)
        {
            Card kaart1 = spelerHans.LayCard();
            Card kaart2 = spelerRogier.LayCard();
            Console.WriteLine($"Rogier legt {kaart2.Color}{kaart2.Number}");
            if (kaart1.Number > kaart2.Number)
            {
                puntenHans++;
            }
            else if (kaart1.Number < kaart2.Number)
            {
                puntenRogier++;
            }
            else
            {
                puntenRogier += 0.5; puntenHans += 0.5;
            }

            Console.WriteLine($"stand: Hans {puntenHans} - Rogier {puntenRogier}");
        }
        // einde
        if (puntenRogier == puntenHans)
        {
            Console.WriteLine($"{Environment.NewLine}gelijkspel!");
        }
        else if (puntenRogier > puntenHans)
        {
            Console.WriteLine($"{Environment.NewLine}Rogier wint!");
        }
        else
        {
            Console.WriteLine($"{Environment.NewLine}Hans wint!");
        }
        Console.ReadKey();
    }
}
