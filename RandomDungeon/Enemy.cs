using System;

namespace RandomDungeon
{
    public class Enemy
    {
        // NÃO MEXER
        public static readonly string[] DefaultNames = new string[]
        {
            "Goblin", "Orc", "Troll", "Skeleton", "Zombie", "Vampire", "Werewolf", "Dark Elf",
            "Slime", "Giant Spider", "Harpy", "Minotaur", "Imp", "Kobold", "Bandit", "Cultist",
            "Wraith", "Ghoul", "Ogre", "Banshee", "Lich", "Gargoyle", "Merfolk", "Golem",
            "Dragonling", "Hydra", "Wyvern", "Specter", "Demon", "Succubus", "Manticore",
            "Chimera", "Elemental", "Phoenix", "Troll King", "Ice Giant", "Fire Elemental",
            "Dark Knight", "Necromancer", "Slaver", "Dire Wolf", "Serpent", "Cursed Knight",
            "Griffin", "Frost Troll", "Shadow Assassin", "Blood Mage", "Stone Guardian",
            "Night Stalker", "Poisonous Snake"
        };

        private string name;
        private int health;
        private int attack;

        public Enemy(string name, int health, int attack)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(int value)
        {
            health = value;
        }

        public int GetAttack()
        {
            return attack;
        }

        public void SetAttack(int value)
        {
            attack = value;
        }

        // Devolve uma String Representando o Inimigo: "Nome (Vida, Ataque)"
        public override string ToString()
        {
            return $"{name} ({health}, {attack})";
        }

        public static Enemy GenerateRandomEnemy(int seed)
        {
            Random rnd = new Random(seed);
            string name = DefaultNames[rnd.Next(DefaultNames.Length)];
            int health = rnd.Next(50, 101);
            int attack = rnd.Next(5, 21);
            return new Enemy(name, health, attack);
        }
    }
}