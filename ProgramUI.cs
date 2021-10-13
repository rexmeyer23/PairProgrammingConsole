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
        public enum Item { sword, shield };
        public List<Item> supplies = new List<Item>();
        //main menu
        public void Title()
        {
            Console.WriteLine("####    ####    ####\n" +
                         "####    ####    ####\n" +
                      "#####################\n" +
                      "##################### \n" +
                      "#####################\n" +
                      "#####################\n" +
                      "#####    #####    ###\n" +
                      "#####    #####    ### \n" +
                      "#####################\n" +
                      "#####################\n" +
                      "#####################\n" +
                      "#########     #######\n" +
                      "#########     #######\n" +
                      "#########     #######\n" +
                      "#########     #######");
            Console.WriteLine("Welcome to The Dark Castle.\n" + "You will be going on a journey where you will be tested on your ability to slay the Fire Breathing Dragon.\n" + "But fear not, the journey may be tough, but you'll ultimately feel rewarded in the end.\n" +
                "Press any key to continue..");
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
                    Console.WriteLine("M*****<3");
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
            Console.WriteLine("You used the GOLD KEY to exit the cage and are now outside the cell.\n" +
                "Press any key to continue...");
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
                    bool inBedroom = true;
                    while (inBedroom)
                    {
                        Console.WriteLine("You are in what looks to be a bedroom.\n" + "The bed is unmade, and the night stand has an abstract painting of what vaguely appears to be a dragon.\n");
                        Console.WriteLine("Above the headboard is a clear glass case holding the ALMIGHTY SWORD.\n");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Do you take the sword? \n" + "Enter: YES or NO");
                        string input3 = Console.ReadLine().ToUpper();
                        if (input3 == "YES")
                        {
                            supplies.Add(Item.sword);
                            Console.WriteLine("You have obtained the ALMIGHTY SWORD!");
                            Console.WriteLine("<<<<<<|xxxxx|");

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else if (input3 == "NO")
                        {
                            Console.WriteLine("You refuse to pick up the sword... So you just admire it from afar. \n" + "Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Please Enter YES or NO");
                        }
                        Console.Clear();
                    }
                    Console.WriteLine("Now that you have claimed the ALMIGHTY SWORD, there is nothing else in here. \n" + "Press Enter to exit the bedroom...");
                    Console.ReadLine();

                }
                else if (input2 == "DINING ROOM")
                {
                    Console.WriteLine("You are now in an elegant dining room where three doors\n" + " stand at the end of the hallway.\n");
                    Console.WriteLine("Press Enter to Continue..... ");
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
                Console.ReadLine();
                Console.WriteLine("There are three doors ahead of you.\n" +
                    "One says OFFICE, one says MAIN ENTRANCE, and one says COURTYARD.\n" +
                    " Which door do you choose?");

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
                            Console.WriteLine("You now have obtained the SHIELD. \n" + "Press any key to continue....");
                            Console.WriteLine("_____");
                            Console.WriteLine(") * (");
                            Console.WriteLine("(___)");

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else if (input3 == "NO")
                        {
                            Console.WriteLine("You refuse to pick up the SHIELD...so you just stare at it blankly.\n" +
                                "Press any key to continue....");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter YES or NO");
                        }

                    }
                    Console.WriteLine("You have claimed the SHIELD, there is nothing else of interest here.\n" +
                        "You can now exit and move forth!");
                }
                else if (doorChoice == "MAIN ENTRANCE")
                {
                    Console.WriteLine("A grand staircase stands before you, but you want to leave.\n" + "On the right side of the MAIN ENTRANCE is a set of double doors.\n" + "Finally, an exit!\n");
                    Console.WriteLine("Unfortunately, when you grab the handles, the door does not budge.\n" + "You are stuck inside with nowhere else to go besides the DINING ROOM.");
                    
                }
                else if (doorChoice == "COURTYARD")
                {
                    Console.WriteLine("The smell of smoke and fire permeates your senses.\n" +
                        " A foggy cloud blankets your vision while a sinister growl\n" +
                        " and heavy, earthshaking footsteps draw you forward...");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter one of the three options:\n" +
                        " OFFICE, MAIN ENTRANCE, or COURTYARD\n" +
                        "Press any key to continue...");
                }
            }
        }
        public void LevelFour()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            if (supplies.Contains(Item.sword) && supplies.Contains(Item.shield))
            {
                Battle.DragonBattle();
                Console.WriteLine("Congratulations!\n" +
                    "You defeated the dragon and won the game.\n" +
                    " You may now leave the castle for good...until next time!");
                Console.WriteLine("Press any key to end the game.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Oh no! You failed to retrieve the SWORD and the SHIELD. The Dragon lifts his foot and smashes you to the ground. You are dead!");
                Console.WriteLine("Press any key to exit the game.");
                Console.ReadLine();
            }

        }
    }

}




