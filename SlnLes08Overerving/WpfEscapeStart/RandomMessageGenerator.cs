using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum MessageType
{
    Default,
    ItemNotFit,
    ItemFit,
    
  
}

public static class RandomMessageGenerator
{
    private static Random random = new Random();

    private static readonly string[] defaultMessages = { "Hmm... That didn't work.", "Interesting, but no.", "Maybe try something else?", "It is firmly locked." };
    private static readonly string[] itemNotFitMessages = { "That doesn't seem to fit.", "I don't think that's the right approach.", "Looks like they don't go together." };
    private static readonly string[] itemFitMessages = {  "That did the trick!","Success! It is now unlocked.","Great! It is now accessible.","Perfect! You've unlocked it" };


    public static string GetRandomMessage(MessageType type)
    {
        switch (type)
        {
            case MessageType.ItemNotFit:
                return itemNotFitMessages[random.Next(itemNotFitMessages.Length)];
            case MessageType.ItemFit:
                return itemFitMessages[random.Next(itemFitMessages.Length)];
           
            default:
                return defaultMessages[random.Next(defaultMessages.Length)];
        }
    }
}
