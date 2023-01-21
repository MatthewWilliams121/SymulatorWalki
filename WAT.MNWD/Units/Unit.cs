using System;
using System.Drawing;
using index.Properties;

namespace index
{
    public class Unit
    {
        protected readonly float initialHealth;

        protected string name;
        protected int identityNumber;
        protected float currentHealth;
        protected string strength;
        protected bool side;
        
        protected Bitmap strengthImage;
        protected Bitmap unitImage;

        public Unit()
        {
        }

        protected Unit(string name, int identityNumber, bool side, string strength)
        {
            this.name = name;
            this.identityNumber = identityNumber;
            this.side = side;
            this.strength = strength;
            setSizeImageAndOrganization();
            initialHealth = currentHealth;
        }

        public int GetSoftAttack()
        {
            return 0;
        }

        public int GetHardAttack()
        {
            return 0;
        }

        public int GetArmor()
        {
            return 0;
        }

        public float InitialHealth => initialHealth;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int IdentityNumber
        {
            get => identityNumber;
            set => identityNumber = value;
        }

        public float CurrentHealth
        {
            get => currentHealth;
            set => currentHealth = value;
        }

        public string Strength
        {
            get => strength;
            set => strength = value;
        }

        public bool Side
        {
            get => side;
            set => side = value;
        }

        public Bitmap StrengthImage
        {
            get => strengthImage;
            set => strengthImage = value;
        }

        public Bitmap UnitImage
        {
            get => unitImage;
            set => unitImage = value;
        }

        public float getOrgPercentage()
        {
            return currentHealth / initialHealth * 100;
        }

        public void setSizeImageAndOrganization()
        {
            if (strength == "Team")
            {
                strengthImage = Resources.Team;
                currentHealth = 1 * 100;
            }
            else if (strength == "Platoon")
            {
                strengthImage = Resources.Platoon;
                currentHealth = 4 * 100;
            }
            //...
        }
    }
}