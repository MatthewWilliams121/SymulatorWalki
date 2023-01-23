using index.Properties;

namespace index
{
    public class Recon : Unit
    {
        public Recon(string name, int identityNumber, bool side, UnitSize strength) : base(name, identityNumber, side, strength)
        {
            this.unitKind = UnitKind.Recon;
            if(side == false)
            {
                unitImage = Resources.nato_recon;
            }else
            {
                unitImage = Resources.hostile_recon;
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