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
        


        public int GetSoftAttack()
        {
            return 7;
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