using System;
using System.Drawing;
using index.Properties;

namespace index
{
    internal class Infantry : Unit
    {
        // equipment inventory[]
        private readonly Bitmap image = Resources.Team; // nie team tylko infantry

        public Infantry(string name, int identityNumber, bool side, UnitSize strength) : base(name, identityNumber, side, strength)
        {
            unitImage = Resources.nato_infantry;
            setSizeImageAndOrganization();
        }

        public Infantry()
        {
        }

        override public int GetSoftAttack()
        {
            return 5;
        }

        override public int GetHardAttack()
        {
            return 2;
        }

        override public int GetArmor()
        {
            return 0;
        }
    }
}