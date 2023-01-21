using System;
using System.Drawing;
using index.Properties;

namespace index
{
    internal class Mechanized : Unit
    {
        public Mechanized()
        {
            Console.Out.WriteLine("Stworzono jednostkę mechanized");
        }

        public Mechanized(string name, int identityNumber, bool side, string strength) : base(name, identityNumber, side, strength)
        {
            unitImage = Resources.nato_mechanized;
            setSizeImageAndOrganization();
        }
        


        override public int GetSoftAttack()
        {
            return 7;
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