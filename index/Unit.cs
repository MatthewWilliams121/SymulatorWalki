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
        System.Drawing.Bitmap SizeImage;
        protected abstract float get_soft_attack();
        protected abstract float get_hard_attack();
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


    }

    internal class NoUnit : Unit

    {
        public NoUnit() { }

        override protected float get_soft_attack() { return 0; }
        override protected float get_hard_attack() { return 0; }
    }
    internal class Infantry : Unit
    {
        // equipment inventory[]
        System.Drawing.Bitmap image =  Properties.Resources.Team; // nie team tylko infantry

        override protected float get_soft_attack() { return 5; }
        override protected float get_hard_attack() { return 2; }

        public Infantry(string name, string size, bool side, int number) {
            this.name = name;
            this.size = size;
            this.number = number;
            this.side = side;
            setSizeImageAndOrganization();
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
        override protected float get_soft_attack() { return 7; }
        override protected float get_hard_attack() { return 2; }
        public Mechanized(string name, string size, bool side, int number)
        {
            this.name = name;
            this.number = number;
            this.size = size;
            this.side = side;
            setSizeImageAndOrganization();
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
