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

        public Mechanized(string name, string strength, bool side, int identityNumber) : base(name, identityNumber, side, strength)
        {
            this.name = name;
            this.identityNumber = identityNumber;
            this.strength = strength;
            this.side = side;
            // this.SizeImage = strength;
            this.unitImage = Resources.nato_mechanized;
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