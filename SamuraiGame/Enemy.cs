using System;

namespace SamuraiGame
{
    public class Enemy
    {
        private static Random random = new Random();

        public string Name { get; private set; }
        public int Health { get; private set; }

        public Enemy()
        {
            string[] enemyTypes = { "Bandit", "Ronin", "Wild Dog" };
            int typeIndex = random.Next(enemyTypes.Length);
            Name = enemyTypes[typeIndex];

            // Set health based on enemy type
            if (Name == "Bandit")
            {
                Health = random.Next(50, 101); // 50-100
            }
            else if (Name == "Ronin")
            {
                Health = random.Next(60, 111); // 60-110
            }
            else if (Name == "Wild Dog")
            {
                Health = random.Next(40, 91); // 40-90
            }
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