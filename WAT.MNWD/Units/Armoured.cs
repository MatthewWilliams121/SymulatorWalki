using index.Properties;

namespace index
{
    public class Armoured : Unit
    {
        public Armoured(string name, int identityNumber, bool side, UnitSize strength) : base(name, identityNumber, side, strength)
        {
            this.unitKind = UnitKind.Armoured;
            if (side == false)
            {
                unitImage = Resources.nato_armoured;
            }
            else
            {
                unitImage = Resources.hostile_armour;
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