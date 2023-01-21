﻿using index.Properties;

namespace index
{
    public class Artillery : Unit
    {
        public Artillery(string name, int identityNumber, bool side, string strength) : base(name, identityNumber, side, strength)
        {
            unitImage = Resources.nato_artilery;
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