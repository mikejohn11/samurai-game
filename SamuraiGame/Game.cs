using System;

namespace SamuraiGame
{
    public class Game
    {
        public void Start()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("   Welcome to Samurai Quest     ");
            Console.WriteLine("===============================");
            Console.WriteLine();

            Player player = new Player();

            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1) Visit the dojo");
                Console.WriteLine("2) Go to the tavern");
                Console.WriteLine("3) Leave the village");
                string choice = Console.ReadLine().Trim();

                if (choice == "1")
                {
                    VisitDojo();
                }
                else if (choice == "2")
                {
                    GoTavern(player);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You decide to leave the village. Farewell, samurai!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
                Console.WriteLine();
            }
        }

        private void VisitDojo()
        {
            Console.WriteLine("You head to the dojo. The master nods and offers some training.");
        }

        private void GoTavern(Player player)
        {
            Console.WriteLine("You enter the tavern. The smell of sake fills the air and townsfolk chatter.");
            Enemy enemy = new Enemy();
            Combat.StartCombat(player, enemy);
        }
    }
}