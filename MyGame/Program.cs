using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(args[0]);

            Enemy[] enemies = new Enemy[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();

                enemies[i] = new Enemy(name, 100, 0);
            }

            foreach (Enemy e in enemies)
            {
                Console.WriteLine($"{e.GetName()} {e.GetHealth()} {e.GetShield()}");
            }
        }
    }
}
