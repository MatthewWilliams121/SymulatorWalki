using index.Properties;

namespace index
{
    public class Artillery : Unit
    {
        public Artillery(string name, int identityNumber, bool side, UnitSize strength) : base(name, identityNumber, side, strength)
        {
            this.unitKind = UnitKind.Artillery;
            if (side == false)
            {
                unitImage = Resources.nato_artilery;
            }
            else
            {
                unitImage = Resources.hostile_artillery;
            }
            setSizeImageAndOrganization();
        }
        override public int GetSoftAttack()
        {
            return 5;
        }

        override public int GetHardAttack()
        {
            return 5;
        }

        override public int GetArmor()
        {
            return 5;
        }
    }
}