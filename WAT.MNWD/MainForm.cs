using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using index.Properties;

namespace index
{
    public partial class MainForm : Form
    {
        private int selected;
        private List<UnitView> unitViewsAttackers;
        private List<UnitView> unitViewsDefenders;
        private int unitsInFormCounter;
        private List<PopUpForm> popUpForms;

        private PopUpForm popUpForm1, popUpForm2, popUpForm3, popUpForm4, popUpForm5, popUpForm6;

        public int UnitsInFormCounter
        {
            get => unitsInFormCounter;
            set => unitsInFormCounter = value;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public int getSelected()
        {
            return selected;
        }

        private void unit1Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 0;
                if (popUpForms[0] != null)
                {
                    popUpForms[0].ShowDialog();
                }
                else
                {
                    popUpForms[0] = new PopUpForm(this);
                    popUpForms[0].ShowDialog();
                }
            }
        }

        private void unit2Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 1;
                if (popUpForms[1] != null)
                {
                    popUpForms[1].ShowDialog();
                }
                else
                {
                    popUpForms[1] = new PopUpForm(this);
                    popUpForms[1].ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 2;
                if (popUpForms[2] != null)
                {
                    popUpForms[2].ShowDialog();
                }
                else
                {
                    popUpForms[2] = new PopUpForm(this);
                    popUpForms[2].ShowDialog();
                }
            }
        }

        private void unit4Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 3;
                if (popUpForms[3] != null)
                {
                    popUpForms[3].ShowDialog();
                }
                else
                {
                    popUpForms[3] = new PopUpForm(this);
                    popUpForms[3].ShowDialog();
                }
            }
        }

        private void unit5Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 4;
                if (popUpForms[4] != null)
                {
                    popUpForms[4].ShowDialog();
                }
                else
                {
                    popUpForms[4] = new PopUpForm(this);
                    popUpForms[4].ShowDialog();
                }
            }
        }

        private void unit6Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 5;
                if (popUpForms[5] != null)
                {
                    popUpForms[5].ShowDialog();
                }
                else
                {
                    popUpForms[5] = new PopUpForm(this);
                    popUpForms[5].ShowDialog();
                }
            }
        }


        private void MainFormLoad(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.plains;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            unitViewsAttackers = new List<UnitView>
            {
                new UnitView(unit1Button, unit1ProgressBar, unit1Number, unit1SizePicture),
                new UnitView(unit2Button, unit2ProgressBar, unit2Number, unit2SizePicture),
                new UnitView(unit3Button, unit3ProgressBar, unit3Number, unit3SizePicture)
            };

            unitViewsDefenders = new List<UnitView>
            {
                new UnitView(unit4Button, unit4ProgressBar, unit4Number, unit4SizePicture),
                new UnitView(unit5Button, unit5ProgressBar, unit5Number, unit5SizePicture),
                new UnitView(unit6Button, unit6ProgressBar, unit6Number, unit6SizePicture)
            };
            popUpForms = new List<PopUpForm>()
            {
                popUpForm1,
                popUpForm2,
                popUpForm3,
                popUpForm4,
                popUpForm5,
                popUpForm6,
            };
        }


        public void refreshForm()
        {
            if (unitsInFormCounter >= 2)
            {
                if (!Battlefield.Turn) turnLabel.Text = "Ruch: atakujący";
                else turnLabel.Text = "Ruch: obrońcy";

                if (!Battlefield.isAnyoneAlive(Battlefield.attackers) ||
                    !Battlefield.isAnyoneAlive(Battlefield.defenders))
                {
                    if (Battlefield.isAnyoneAlive(Battlefield.attackers)) turnLabel.Text = "Wygrał atakujący.";
                    else turnLabel.Text = "Wygrała obrona";

                    Battlefield.isFight = false;
                }
            }
            else
            {
                turnLabel.Text = "";
            }

            var units = Battlefield.attackers.Concat(Battlefield.defenders).ToList();
            int i = 0;
            foreach (var unitView in unitViewsAttackers.Concat(unitViewsDefenders).ToList())
            {
                unitView.mainPicture.Image = units[i].UnitImage;
                unitView.identity.Text = units[i].IdentityNumber.ToString();
                unitView.strength.Image = units[i].StrengthImage;

                if (unitView.mainPicture.Image != null && (int)units[i].getOrgPercentage() > 0)
                    unitView.health.Value = (int)units[i].getOrgPercentage();
                else
                    unitView.health.Value = 0;
                i++;
            }
        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight && unitsInFormCounter >= 2)
                Battlefield.resolve(this);
        }

        private void switchSidesButton_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                Battlefield.switchSides(this);
            }
        }

        private void regenerateUnitsButton_Click(object sender, EventArgs e)
        {
            foreach (var unit in Battlefield.attackers.Concat(Battlefield.defenders).ToList())
            {
                unit.CurrentHealth = unit.InitialHealth;
            }

            refreshForm();
        }


        private void removeUnit1_Click(object sender, EventArgs e)
        {
            if (!Battlefield.attackers[0].Equals(new Unit()))
            {
                popUpForms[0] = null;
                Battlefield.attackers[0] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }

        private void removeUnit2_Click(object sender, EventArgs e)
        {
            if (!Battlefield.attackers[1].Equals(new Unit()))
            {
                popUpForms[1] = null;
                Battlefield.attackers[1] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }

        private void removeUnit3_Click(object sender, EventArgs e)
        {
            if (!Battlefield.attackers[2].Equals(new Unit()))
            {
                popUpForms[2] = null;
                Battlefield.attackers[2] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }

        private void removeUnit4_Click(object sender, EventArgs e)
        {
            if (!Battlefield.defenders[0].Equals(new Unit()))
            {
                popUpForms[3] = null;
                Battlefield.defenders[0] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }


        private void removeUnit5_Click(object sender, EventArgs e)
        {
            if (!Battlefield.defenders[1].Equals(new Unit()))
            {
                popUpForms[4] = null;
                Battlefield.defenders[1] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }

        private void removeUnit6_Click(object sender, EventArgs e)
        {
            if (!Battlefield.defenders[2].Equals(new Unit()))
            {
                popUpForms[5] = null;
                Battlefield.defenders[2] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }
        

        public List<PopUpForm> PopUpForms
        {

            get => popUpForms;
            set => popUpForms = value;

        }
    }
}