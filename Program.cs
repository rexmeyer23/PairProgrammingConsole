using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleAssignment
{
    class Program
    {
        public static Hero currentPlayer = new Hero();
        static void Main(string[] args)
        {
            ProgramUI game = new ProgramUI();
            game.Title();
            game.LevelOne();
            game.LevelTwo();
            game.LevelThree(); 
            game.LevelFour(); 
        }
    }
}
