using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
namespace WpfEscapeStart
{
    internal class Room
    {
        public string Name { get; } 
        public string Description { get; }
        public string Screenshot { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Door> Doors { get; set; } = new List<Door>();
        public Room(string name, string desc)
        {
            Name = name;
            Description = desc;

        }
    }
}
