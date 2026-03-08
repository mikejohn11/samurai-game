using System;

namespace SamuraiGame
{
    public class Combat
    {
        private static Random random = new Random();

        public static void StartCombat(Player player, Enemy enemy)
        {
            Console.WriteLine($"A {enemy.Name} appears with {enemy.Health} health!");

            while (player.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine("What will you do?");
                Console.WriteLine("1) Fight");
                Console.WriteLine("2) Run");
                string choice = Console.ReadLine()?.Trim() ?? "";

                if (choice == "1")
                {
                    // Player attacks
                    int playerDamage = random.Next(20, 51); // 20 to 50
                    enemy.TakeDamage(playerDamage);
                    Console.WriteLine($"You deal {playerDamage} damage to the {enemy.Name}. {enemy.Name} health: {enemy.Health}");

                    if (enemy.IsAlive)
                    {
                        // Enemy attacks
                        int enemyDamage = random.Next(10, 31); // 10 to 30
                        player.TakeDamage(enemyDamage);
                        Console.WriteLine($"The {enemy.Name} deals {enemyDamage} damage to you. Your health: {player.Health}");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You run away from the enemy.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
                Console.WriteLine();
            }

            if (!player.IsAlive)
            {
                Console.WriteLine("You have been defeated!");
            }
            else if (!enemy.IsAlive)
            {
                Console.WriteLine($"You have defeated the {enemy.Name}!");
            }
        }
    }
}