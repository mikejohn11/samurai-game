using System;

namespace SamuraiGame
{
    public class Player
    {
        public int Health { get; private set; }

        public Player()
        {
            Health = 100; // Starting health
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0; // Prevent negative health
            }
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }
    }
}