using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PairProgrammingConsoleAssignment.ProgramUI;

namespace PairProgrammingConsoleAssignment
{
    class Locations
    {

        
        //public List<string> Exits { get; }
       // public string Filler { get;  }
        public List<Item> Items { get; }
        public void AddItem (Item item)
        {
            if (Items.Contains(item))
            {
                Items.Add(item);
            }
        }
        public Locations() { }
        public Locations(string filler, List<string> exits, List<Item> items )
        {
            //Exits = exits;
            Items = items;
        }

       
    }
}
