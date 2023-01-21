using System;
using System.Drawing;
using index.Properties;

namespace index
{
    internal class Infantry : Unit
    {
        // equipment inventory[]
        private readonly Bitmap image = Resources.Team; // nie team tylko infantry

        public Infantry(string name, int identityNumber, bool side, string strength) : base(name, identityNumber, side, strength)
        { 
            unitImage = Resources.nato;
            setSizeImageAndOrganization();
        }

        public Infantry()
        {
        }

        public int GetSoftAttack()
        {
            return 5;
        }

        public int GetHardAttack()
        {
            return 2;
        }

        public int GetArmor()
        {
            return 0;
        }
    }
}