using System.Windows.Forms;

namespace index
{
    public class UnitView
    {
        public Label identity;
        public ProgressBar health;
        public PictureBox strength;
        public Button mainPicture;


        public UnitView(Button mainPicture, ProgressBar health, Label identity, PictureBox strength)
        {
            this.mainPicture = mainPicture;
            this.health = health;
            this.identity = identity;
            this.strength = strength;
        }

        public Label Identity
        {
            get => identity;
            set => identity = value;
        }

        public ProgressBar Health
        {
            get => health;
            set => health = value;
        }

        public PictureBox Strength
        {
            get => strength;
            set => strength = value;
        }

        public Button MainPicture
        {
            get => mainPicture;
            set => mainPicture = value;
        }
    }
}