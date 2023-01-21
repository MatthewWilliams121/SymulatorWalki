﻿using index.Properties;

namespace index
{
    public class Recon : Unit
    {
        public Recon(string name, int identityNumber, bool side, string strength) : base(name, identityNumber, side, strength)
        {
            unitImage = Resources.nato_recon;
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