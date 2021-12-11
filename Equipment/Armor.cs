using TheJusticeLeague_vs._TheLegionOfDoom.Enum;
namespace TheJusticeLeague_vs._TheLegionOfDoom.Equipment
{
     class Armor
    {
        public const int JUSTICE_LEAGUE_ARMOR = 5;
        public const int THE_LEGION_OF_DOOM = 5;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }
        public Armor(Faction faction)
        {
        switch (faction)
            {
                case Faction.JusticeLeague:
                    armorPoints = JUSTICE_LEAGUE_ARMOR;
                    break;
                case Faction.LegionOfDoom:
                    armorPoints = THE_LEGION_OF_DOOM;
                    break;
            }
        }
    }
}