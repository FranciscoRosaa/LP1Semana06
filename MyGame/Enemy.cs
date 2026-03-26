using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name, float health, float shield)
        {

            SetName(name);
            this.health = health;
            this.shield = shield;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string newName)
        {
            name = "";

            name = (newName ?? "").Substring(0, Math.Min(8, (newName ?? "").Length));
        }

        public string GetName()
        {
            return name;
        }
        
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }


    }
}