using System;

namespace SamuraiGame
{
    public class Player
    {
        public int MaxHealth { get; private set; } = 100;
        public int Health { get; private set; }
        public int Experience { get; private set; }
        public int Level { get; private set; } = 1;

        public Player()
        {
            Health = MaxHealth; // Starting health
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0; // Prevent negative health
            }
        }

        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth; // Prevent exceeding max health
            }
        }

        public void GainExperience(int amount)
        {
            Experience += amount;
            if (Experience >= 100)
            {
                Level++;
                Experience = 0; // Reset experience after leveling
                Console.WriteLine($"Congratulations! You leveled up to level {Level}!");
            }
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }
    }
}