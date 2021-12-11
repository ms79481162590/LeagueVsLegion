using System;
using System.Threading;
using TheJusticeLeague_vs._TheLegionOfDoom.Enum;
using TheJusticeLeague_vs._TheLegionOfDoom.Equipment;

namespace LeagueVsLegion
{
    class Fighters
    {
        private const int JUSTICE_LEAGUE_STARTING_HEALTH = 20;
        private const int THE_LEGION_OF_DOOM = 20;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Fighters(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.JusticeLeague:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = JUSTICE_LEAGUE_STARTING_HEALTH;
                    break;
                case Faction.LegionOfDoom:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = THE_LEGION_OF_DOOM;
                    break;
                default:
                    break;
            }

        }
        public void Attack(Fighters enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;
            enemy.health -= damage;

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious", ConsoleColor.Blue);

            }
            else
            {
                System.Console.WriteLine($"{name} attacked {enemy.name}. {damage} damage was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.health}");
            }
            Thread.Sleep(200);
        }
    }
    class EntryPoint
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            Fighters JusticeLeague = new Fighters("Superman", Faction.JusticeLeague);
            Fighters LegionOfDoom = new Fighters("Bizzaro", Faction.LegionOfDoom);
            while(JusticeLeague.IsAlive && LegionOfDoom.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                    JusticeLeague.Attack(LegionOfDoom);
                }
                else
                {
                    LegionOfDoom.Attack(JusticeLeague);
                }
                Thread.Sleep(200);
            }
            
        }
    }
}
