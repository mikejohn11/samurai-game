using System;

namespace SamuraiGame
{
    public class Enemy
    {
        private static Random random = new Random();

        public int Health { get; private set; }

        public Enemy()
        {
            Health = random.Next(50, 101); // Random health between 50 and 100
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