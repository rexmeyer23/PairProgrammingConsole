using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingConsoleAssignment
{
    public class Battle
    {
        static Random rand = new Random();
        public static void DragonBattle()
        {
            Console.WriteLine("The fire breathing dragon stands before you!");
            Console.WriteLine("Quick, draw your sword and shield!\n" +
                "Defeat the dragon, and you'll win the game!");
            Console.ReadKey();
            Combat("Firebreathing Dragon", 1, 4);
        }
        public static void Combat(string name, int power, int health)
        {
            string n = " ";
            int p = 0;
            int h = 0;
            n = name;
            p = power;
            h = health;
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + n);
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (B)lock |");
                Console.WriteLine("=====================");
                Console.WriteLine("Health: " +Program.currentPlayer.health);
                string input = Console.ReadLine();
                if(input.ToUpper() == "A" || input.ToUpper() == "ATTACK")
                {
                    //Attack
                    Console.WriteLine("You draw your sword to slay the dragon\n" +
                        "You lunge forward and jab "+n+" in the stomach.\n" +
                        "Unfortunately, the "+n+" whips his tail back at you, dealing a devastating blow.\n");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose "+ damage + "health and deal "+attack+" damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToUpper() == "B" || input.ToUpper() == "BLOCK")
                {
                    //Block
                    Console.WriteLine("The " + n + " takes a great big inhale as he prepares to unleash a fountain of fire pouring from his wide open mouth\n");
                    Console.WriteLine("You lean back and swing your shield in front of you as the dragon breathes his fire upon you.\n");
                    int damage = (p/4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + "health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
            }
        }
    }
}
