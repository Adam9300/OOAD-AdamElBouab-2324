using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEscapeStart
{
    internal class Door
    {
        public bool IsOpen { get; private set; }
        public bool IsLocked { get; private set; }
        public Item Key { get; private set; }
        public Room ConnectedRoom { get; private set; }
        public string Name { get; private set; }
        private static HashSet<string> usedColors = new HashSet<string>();

        public Door(Room connectedRoom, string state, Item key = null)
        {
            ConnectedRoom = connectedRoom;
            IsOpen = state == "open";
            IsLocked = state == "closed";
            Key = key;
            Name = GenerateUniqueColorName();
            if(state == "open" && key==null)
            {
                IsOpen = true;
                IsLocked = false;
            }
        }
        private string GenerateUniqueColorName()
        {
            string[] colorNames = new string[]
            {
            "Red", "Blue", "Green", "Yellow", "Orange", "Purple", "Pink", "Brown", "Black", "White"
            };

            Random random = new Random();
            int index = random.Next(colorNames.Length);

            string colorName = colorNames[index];
            while (usedColors.Contains(colorName))
            {
                index = random.Next(colorNames.Length);
                colorName = colorNames[index];
            }

            usedColors.Add(colorName);
            return colorName;
        }
        public void Open()
        {
            if (IsLocked)
            {
                Console.WriteLine("The door is locked.");
                return;
            }

            IsOpen = true;
            Console.WriteLine("The door is now open.");
        }

       
       

        public void Unlock(Item key)
        {
            if (key != null && Key == key)
            {
                IsLocked = false;
                IsOpen = true;
                Console.WriteLine("The door is now unlocked.");
            }
            else
            {
                Console.WriteLine("The key doesn't fit.");
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }


}
