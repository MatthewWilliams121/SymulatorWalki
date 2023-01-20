using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    abstract class Unit
    {
        protected string name;
        protected int number;
        protected string size;
        protected float organization;
        protected bool side;
        protected float initialOrg;
        public float getOrganization()
        {
            return this.organization;
        }
        System.Drawing.Bitmap SizeImage;
        public abstract int get_soft_attack();
        public abstract int get_hard_attack();
        public abstract int get_armor();
        virtual public System.Drawing.Bitmap getImageUnit() { return null; }
        virtual public System.Drawing.Bitmap getUnitSizeImage() { return SizeImage; }
        public int getNumber()
        {
            return number;
        }
        public string getName()
        {
            return name;
        }

        public float getOrgPercentage()
        {
            return this.organization / this.initialOrg * 100;
        }

        public void setSizeImageAndOrganization()
        {
            if(size == "Team")
            {
                SizeImage = Properties.Resources.Team;
                this.organization = 1 * 100;
            }
            else if (size == "Platoon")
            {
                SizeImage = Properties.Resources.Platoon;
                this.organization = 4 * 100;
            }
            //...
        }
        public void setOrganization(float organization)
        {
            this.organization = organization;
        }


    }

    internal class NoUnit : Unit

    {
        public NoUnit() { }

        override public int get_soft_attack() { return 0; }
        override public int get_hard_attack() { return 0; }
        override public int get_armor() { return 0; }
    }
    internal class Infantry : Unit
    {
        // equipment inventory[]
        System.Drawing.Bitmap image =  Properties.Resources.Team; // nie team tylko infantry

        override public int get_soft_attack() { return 5; }
        override public int get_hard_attack() { return 2; }
        override public int get_armor() { return 0; }
        public Infantry(string name, string size, bool side, int number) {
            this.name = name;
            this.size = size;
            this.number = number;
            this.side = side;
            setSizeImageAndOrganization();
            this.initialOrg = this.organization;
        }
        
        public System.Drawing.Bitmap getImageUnit()
        {
            return image;
        }

    }
    internal class Mechanized : Unit
    {
        // equipment inventory[]
        System.Drawing.Bitmap image = Properties.Resources.nato_mechanized;
        override public int get_soft_attack() { return 7; }
        override public int get_hard_attack() { return 2; }
        override public int get_armor() { return 0; }
        public Mechanized(string name, string size, bool side, int number)
        {
            this.name = name;
            this.number = number;
            this.size = size;
            this.side = side;
            setSizeImageAndOrganization();
            this.initialOrg = this.organization;
        }
        override public System.Drawing.Bitmap getImageUnit()
        {
            return image;
        }
    }
    internal class equipment
    {

    }
}
