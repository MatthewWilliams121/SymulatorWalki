using System;
using System.Drawing;
using index.Properties;

namespace index
{
    internal class Infantry : Unit
    {
        // equipment inventory[]
        private readonly Bitmap image = Resources.Team; // nie team tylko infantry

        public Infantry(string name, string strength, bool side, int identityNumber) : base(name, identityNumber, side, strength)
        {
            this.name = name;
            this.strength = strength;
            this.identityNumber = identityNumber;
            this.side = side;
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

        public Bitmap getImageUnit()
        {
            return image;
        }
    }
}