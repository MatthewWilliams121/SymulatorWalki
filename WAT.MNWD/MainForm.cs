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
                if (popUpForm1 != null)
                {
                    popUpForm1.ShowDialog();
                }
                else
                {
                    popUpForm1 = new PopUpForm(this);
                    popUpForm1.ShowDialog();
                }
            }
        }

        private void unit2Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 1;
                if (popUpForm2 != null)
                {
                    popUpForm2.ShowDialog();
                }
                else
                {
                    popUpForm2 = new PopUpForm(this);
                    popUpForm2.ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 2;
                if (popUpForm3 != null)
                {
                    popUpForm3.ShowDialog();
                }
                else
                {
                    popUpForm3 = new PopUpForm(this);
                    popUpForm3.ShowDialog();
                }
            }
        }

        private void unit4Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 3;          
                if (popUpForm4 != null)
                {
                    popUpForm4.ShowDialog();
                }
                else
                {
                    popUpForm4 = new PopUpForm(this);
                    popUpForm4.ShowDialog();
                }
            }
        }

        private void unit5Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 4;
                if (popUpForm5 != null)
                {
                    popUpForm5.ShowDialog();
                }
                else
                {
                    popUpForm5 = new PopUpForm(this);
                    popUpForm5.ShowDialog();
                }
            }
        }

        private void unit6Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 5;
                if (popUpForm6 != null)
                {
                    popUpForm6.ShowDialog();
                }
                else
                {
                    popUpForm6 = new PopUpForm(this);
                    popUpForm6.ShowDialog();
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
        }


        public void refreshForm()
        {
            if ( unitsInFormCounter >= 2)
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
                Battlefield.switchSides(this);
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
                popUpForm1 = null;
                Battlefield.attackers[0] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }
        
        private void removeUnit2_Click(object sender, EventArgs e)
        {
            if (!Battlefield.attackers[1].Equals(new Unit()))
            {
                popUpForm2 = null;
                Battlefield.attackers[1] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }

        private void removeUnit3_Click(object sender, EventArgs e)
        {
            if(!Battlefield.attackers[2].Equals(new Unit()))
            {
                popUpForm3 = null;
                Battlefield.attackers[2] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }

        private void removeUnit4_Click(object sender, EventArgs e)
        {
            if (!Battlefield.defenders[0].Equals(new Unit()))
            {
                popUpForm4 = null;
                Battlefield.defenders[0] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }
        }
        

        private void removeUnit5_Click(object sender, EventArgs e)
        {
            if (!Battlefield.defenders[1].Equals(new Unit()))
            {
                popUpForm5 = null;
                Battlefield.defenders[1] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }     
        }

        private void removeUnit6_Click(object sender, EventArgs e)
        {
            if (!Battlefield.defenders[2].Equals(new Unit()))
            {
                popUpForm6 = null;
                Battlefield.defenders[2] = new Unit();
                unitsInFormCounter--;
                refreshForm();
            }     
        }

        private void zestaw1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Battlefield.attackers[0]  = new Mechanized("Test", 10, false, UnitSize.Company);
            popUpForm1 = new PopUpForm(this, Battlefield.attackers[0]);
            
            Battlefield.defenders[0]  = new Artillery("Test2", 100, true, UnitSize.Company);
            
            popUpForm4 = new PopUpForm(this, Battlefield.defenders[0]);
            unitsInFormCounter = 2;

            Battlefield.attackers[1] = Battlefield.attackers[2] = new Unit();
            Battlefield.defenders[1] = Battlefield.defenders[2] = new Unit();

            refreshForm();
            
        }
    }
}