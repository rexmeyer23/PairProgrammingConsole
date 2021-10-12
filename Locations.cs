using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleAssignment
{
    class Locations
    {
        public List<string> Exits { get; }
        public string Filler { get;  }

        public Locations(string filler, List<string> exits )
        {
            Exits = exits;
        }
    }
}
