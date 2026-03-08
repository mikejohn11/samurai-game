using System;

namespace SamuraiGame
{
    public class Game
    {
        private Random random = new Random();

        public void Start()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("   Welcome to Samurai Quest     ");
            Console.WriteLine("===============================");
            Console.WriteLine();

            Player player = new Player();

            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1) Visit the dojo");
                Console.WriteLine("2) Go to the tavern");
                Console.WriteLine("3) Leave the village");
                string choice = Console.ReadLine()?.Trim() ?? "";

                if (choice == "1")
                {
                    VisitDojo(player);
                }
                else if (choice == "2")
                {
                    GoTavern(player);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You decide to leave the village. Farewell, samurai!");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
                Console.WriteLine();
            }
        }

        private void VisitDojo(Player player)
        {
            Console.WriteLine("You head to the dojo. The master nods and offers some training.");
            int healAmount = random.Next(10, 31); // Random heal between 10 and 30
            player.Heal(healAmount);
            Console.WriteLine($"You feel refreshed! Restored {healAmount} health. Your health is now {player.Health}.");
        }

        private void GoTavern(Player player)
        {
            Console.WriteLine("You enter the tavern. The smell of sake fills the air and townsfolk chatter.");
            Enemy enemy = new Enemy();
            Combat.StartCombat(player, enemy);
        }
    }
}