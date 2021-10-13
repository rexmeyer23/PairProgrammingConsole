﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleAssignment
{
    class ProgramUI
    {
        //items needed to win the game
        public enum Item { sword, shield };
        public List<Item> supplies = new List<Item>();
        //list of rooms
        //Dictionary<string, Locations> Locations = new Dictionary<string, Locations>()
        //{
        //    {"outside cell", outside_cell },
        //    {"bedroom", bedroom },
        //    {"dining room", dining_room },
        //    {"office",  office },
        //    {"main entrance",  main_entrance },
        //    {"courtyard",  courtyard },
        //};
        //public static Locations bedroom = new Locations("You are in what looks to be a bedroom.\n" + "The bed is unmade, and the night stand has an abstract painting of what vaguely appears to be a dragon.\n" +
        //    "On the other side of the bed room, a class case is holding an almighty sword.\n" +
        //    "Do you want take the SWORD?\n",
        //    new List<string> { "outside cell" });
        //public static Locations dining_room = new Locations("You are now in a elegant dining room where three doors\n" +
        //    " stand at the end of the hallway.\n" +
        //    "Each door has as sign above them stating their respective rooms.\n" +
        //    "Which door would you like to go through?\n" +
        //    "OFFICE, MAIN ENTRACE, or COURTYARD", new List<string> { "office", "main entrance", "courtyard" });
        //public static Locations outside_cell = new Locations("You see two doors.\n" +
        //            "The left door says BEDROOM and the right door says DINING ROOM.\n" + "Which room do you want to enter?\n",
        //    new List<string> { "dining room", "bedroom" });
        //public static Locations office = new Locations("In what looks to be a dimly lit, yet sophisticated office\n" +
        //    "there is SHIELD hanging on the wall above the fireplace.\n" +
        //    "Do you want to take the SHIELD?", new List<string> { "dining room" });
        //public static Locations main_entrance = new Locations("A grand staircase stands before you, but you want leave.\n" +
        //    "But on the right side of the MAIN ENTRANCE is a set of double doors.\n" +
        //    "Finally, an exit!\n" +
        //    "Unfortunately, when you grab the handles, the door does not budge.\n" +
        //    "You are stuck inside and nowhere else to go besides the DINING ROOM.", new List<string> { "dining room" });
        //public static Locations courtyard = new Locations("AHHHHH!\n" +
        //    "The fire breathing dragon stands before you.\n",
        //    new List<string> { });
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

            bool bedroomOrDiningRoom = true;
            while (bedroomOrDiningRoom)
            {
                Console.WriteLine("You see two doors.\n" +
                    "The left door says BEDROOM and the right door says DINING ROOM.\n" + "Which room do you want to enter?\n");
                string input2 = Console.ReadLine().ToUpper();
                if (input2 == "BEDROOM")
                {
                    Console.WriteLine("You are in what looks to be a bedroom.\n" + "The bed is unmade, and the night stand has an abstract painting of what vaguely appears to be a dragon.\n" + "Congratulations! You have found the almighty sword. \n" + "Press Enter to continue exit the room....");
                    supplies.Add(Item.sword);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input2 == "DINING ROOM")
                {
                    Console.WriteLine("You are now in an elegant dining room where three doors\n" +
                " stand at the end of the hallway.\n" +
                "Press Enter to Continue..... ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter one of the following options : BEDROOM or DINING ROOM");
                }
            }


        }
        public void LevelThree()
        {
            bool insideDiningRoom = true;
            while (insideDiningRoom)
            {
                Console.WriteLine("You are in the dining room. There are three doors ahead of you. One says OFFICE, one says MAIN ENTRANCE, and one says COURTYARD. Which door do you choose?");

                string doorChoice = Console.ReadLine().ToUpper();
                if (doorChoice == "OFFICE")
                {
                    bool inOffice = true;
                    while (inOffice)
                    {
                        Console.WriteLine("In what looks to be a dimly lit, yet sophisticated office\n" +
                    "there is SHIELD hanging on the wall above the fireplace.....\n");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Do you take the SHIELD?\n" + "Enter: YES or NO");
                        string input3 = Console.ReadLine().ToUpper();
                        if (input3 == "YES")
                        {
                            supplies.Add(Item.shield);
                            Console.WriteLine("You now have obtained the SHIELD. \n" + "Press Enter to continue.....");

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else if (input3 == "NO")
                        {
                            Console.WriteLine("You refuse to pick up the SHIELD...so you just stare at it blankly.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter in a command option.....");
                        }

                    }
                    Console.WriteLine("You have claimed the SHIELD, there is nothing else of interest here...you can now exit and move forth!");
                }
                else if (doorChoice == "MAIN ENTRANCE")
                {
                    Console.WriteLine("There looks to be an exit, but the doors to get out are barracaded.You must go back to the dining room");
                }
                else if (doorChoice == "COURTYARD")
                {
                    Console.WriteLine("The smell of smoke and fire permeates your senses. A foggy cloud blankets your vision. A sinister growl and heavy, earthshaking footsteps lead you forward...");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter one of the three options:\n" +
                        " OFFICE, MAIN ENTRANCE, or COURTYARD");
                }
            }
        }
        public void LevelFour()
        {
            Console.WriteLine("The dragon is in front of you");
            Console.ReadKey();
            if (supplies.Contains(Item.sword) && supplies.Contains(Item.shield))
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You die!");
            }

        }
    }

}




