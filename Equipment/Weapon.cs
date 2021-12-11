using TheJusticeLeague_vs._TheLegionOfDoom.Enum;
namespace TheJusticeLeague_vs._TheLegionOfDoom.Equipment
{
    internal class Weapon
    {
        private const int JUSTICE_DAMAGE = 5;
        private const int LEGION_DAMAGE = 5;
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public Weapon(Faction faction)
        {
            switch(faction)
            {
                case Faction.JusticeLeague:
                    damage = JUSTICE_DAMAGE;
                    break;
                case Faction.LegionOfDoom:
                    damage = LEGION_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}