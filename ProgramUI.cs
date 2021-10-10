using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleAssignment
{
    class ProgramUI
    {
        //items needed to win the game
        //public enum Item { sword, shield };
        //public List<Item> supplies = new List<Item>();
        //list of rooms
        Dictionary<string, Locations> Location = new Dictionary<string, Locations>()
        {
            {"bedroom", bedroom },
            {"dining room", dining_room },
            {"office",  office },
            {"main entrance",  main_entrance },
            {"courtyard",  courtyard },
        };
        public static Locations bedroom = new Locations("You are in what looks to be a bedroom.\n" + "The bed is unmade, and the night stand has an abstract painting of what vaguely appears to be a dragon.\n" +
            "On the other side of the bed room, a class case is holding an almighty sword.\n" +
            "Do you want take the SWORD?\n");
        public static Locations dining_room = new Locations("You are now in a elegant dining room where three doors\n" +
            " stand at the end of the hallway.\n" +
            "Each door has as sign above them stating their respective rooms.\n" +
            "Which door would you like to go through?\n" +
            "OFFICE, MAIN ENTRACE, or COURTYARD");
        public static Locations office = new Locations("In what looks to be a dimly lit, yet sophisticated office\n" +
            "there is SHIELD hanging on the wall above the fireplace.\n" +
            "Do you want to take the SHIELD?");
        public static Locations main_entrance = new Locations("A grand staircase stands before you, but you want leave.\n" +
            "But on the right side of the MAIN ENTRANCE is a set of double doors.\n" +
            "Finally, an exit!\n" +
            "Unfortunately, when you grab the handles, the door does not budge.\n" +
            "You are stuck inside and nowhere else to go besides the DINING ROOM.");
        public static Locations courtyard = new Locations("AHHHHH!\n" +
            "The fire breathing dragon stands before you.\n");
        //main menu
        public void Title()
        {
            Console.WriteLine("Welcome to the Hidden Castle.\n" + "You will be going on a journey where you will be tested on your knowledge in order to slay the Mad Dragon.\n" + "But fear not, the journey may be tough, but you'll ultimately feel rewarded in the end.");
            Console.ReadLine();
            Console.WriteLine("So let's begin!");
            Console.ReadLine();
            Console.Clear();
        }
        //start of game aka level one
        public void LevelOne()
        {
            Console.WriteLine("You wake up in a dusty, grimey dungeon where all that's beside you\n" +
                "is an empty potato sack, a burnt candle, and a mountain of hay.\n" + "You want to leave, but the cage is locked.\n" + "Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You look around and see a shiny object sticking out of the hay.");
            bool lockedInside = true;
            while (lockedInside)
            {
                Console.WriteLine("\nDo you want to pick up the object?\n" + "Enter: YES or NO");
                string input = Console.ReadLine().ToUpper();
                if (input == "YES")
                {
                    Console.WriteLine("You now have the Gold KEY.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }     //work on spacing of text
                else if (input == "NO")
                {
                    Console.WriteLine("You are still locked inside.");
                }
                else
                {
                    Console.WriteLine("Please enter YES or NO");
                }
            }
            Console.WriteLine("You used the GOLD KEY to exit the cage and are now outside the cell.");
        }
        public void LevelTwo()
        {
            Console.WriteLine("You see two doors.\n" +
                    "The left door says BEDROOM and the right door says DINING ROOM.\n" + "Which room do you want to enter?\n");
            Console.ReadKey();
        }

    }


}

