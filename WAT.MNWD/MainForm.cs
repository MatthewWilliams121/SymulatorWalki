using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace index
{
    public partial class MainForm : Form
    {
        private List<Button> buttonListAttacker;
        private List<Button> buttonListDenfender;
        private int selected;
        private List<UnitView> unitViews;
        private List<UnitView> unitViews2;

        public MainForm()
        {
            InitializeComponent();
        }

        public int getSelected()
        {
            return selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected = 0;
            var f2 = new PopUpForm(this);
            f2.ShowDialog();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            unitViews = new List<UnitView>
            {
                new UnitView(unit1Button, unit1ProgressBar, unit1Number, unit1SizePicture),
                new UnitView(unit2Button, unit2ProgressBar, unit2Number, unit2SizePicture),
                new UnitView(unit3Button, unit3ProgressBar, unit3Number, unit3SizePicture)
            };

            unitViews2 = new List<UnitView>
            {
                new UnitView(unit4Button, unit4ProgressBar, unit4Number, unit4SizePicture),
                new UnitView(unit5Button, unit5ProgressBar, unit5Number, unit5SizePicture),
                new UnitView(unit6Button, unit6ProgressBar, unit6Number, unit6SizePicture)
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selected = 2;
            var f2 = new PopUpForm(this);
            f2.ShowDialog();
        }

        public void refreshForm()
        {
            var i = 0;
            foreach (var unit in unitViews)
            {
                if (i < Battlefield.attacker.Count)
                {
                    unit.mainPicture.Image = Battlefield.attacker[i].UnitImage;
                    unit.identity.Text = Battlefield.attacker[i].IdentityNumber.ToString();
                    unit.strength.Image = Battlefield.attacker[i].StrengthImage;
                    
                    if (unit.mainPicture.Image != null && (int)Battlefield.attacker[i].getOrgPercentage() > 0)
                        unit.health.Value = (int)Battlefield.attacker[i].getOrgPercentage();
                    else
                        unit.health.Value = 0;
                }

                i++;
            }

            i = 0;
            foreach (var unit in unitViews2)
            {
                if (i < Battlefield.defender.Count)
                {
                    unit.mainPicture.Image = Battlefield.defender[i].UnitImage;
                    unit.identity.Text = Battlefield.defender[i].IdentityNumber.ToString();
                    unit.strength.Image = Battlefield.defender[i].StrengthImage;
                    if (unit.mainPicture.Image != null && (int)Battlefield.defender[i].getOrgPercentage() > 0)
                        unit.health.Value = (int)Battlefield.defender[i].getOrgPercentage();
                    else
                        unit.health.Value = 0;
                }

                i++;
            }
        }

        private void unit2Button_Click(object sender, EventArgs e)
        {
            selected = 1;
            new PopUpForm(this).ShowDialog();
        }

        private void unit4Button_Click(object sender, EventArgs e)
        {
            selected = 3;
            new PopUpForm(this).ShowDialog();
        }

        private void unit5Button_Click(object sender, EventArgs e)
        {
            selected = 4;
            new PopUpForm(this).ShowDialog();
        }

        private void unit6Button_Click(object sender, EventArgs e)
        {
            selected = 5;
            new PopUpForm(this).ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }


        private void simulateButton_Click(object sender, EventArgs e)
        {
            Battlefield.resolve(this);
        }

        private void switchSidesButton_Click(object sender, EventArgs e)
        {
            Battlefield.switchSides(this);
        }
    }
}