using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy> value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public void ShowEnemies()
        {
            Console.Write("Arena: ");
            for (int i = 0; i < enemies.Count; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(enemies[i].GetName());
            }
            Console.WriteLine();
        }
        
        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            // Subtrai o Ataque do Atacante à Vida do Defensor
            // Garante que a Vida Não Fique Negativa
            int newHealth = defender.GetHealth() - attacker.GetAttack();

            if (newHealth < 0) newHealth = 0;
            defender.SetHealth(newHealth);
            
            // Se a Vida do Defensor Chegar a 0, Remove-o da Arena
            if (defender.GetHealth() == 0)
            {
                RemoveEnemy(defender);
            }
        }
    }
}