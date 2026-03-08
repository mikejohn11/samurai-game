using System;

namespace SamuraiGame
{
    public class Player
    {
        public int MaxHealth { get; private set; } = 100;
        public int Health { get; private set; }

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

        public bool IsAlive
        {
            get { return Health > 0; }
        }
    }
}