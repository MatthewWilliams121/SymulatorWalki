using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace index
{
    public partial class MainForm : Form
    {
        private int selected;
        private List<UnitView> unitViewsAttackers;
        private List<UnitView> unitViewsDefenders;

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
                new PopUpForm(this).ShowDialog();
            }
        }

        private void unit2Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 1;
                new PopUpForm(this).ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 2;
                new PopUpForm(this).ShowDialog();
            }
        }

        private void unit4Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 3;
                new PopUpForm(this).ShowDialog();
            }
        }

        private void unit5Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 4;
                new PopUpForm(this).ShowDialog();
            }
        }

        private void unit6Button_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
            {
                selected = 5;
                new PopUpForm(this).ShowDialog();
            }
        }


        private void MainFormLoad(object sender, EventArgs e)
        {
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
            if (Battlefield.Turn) turnLabel.Text = "Ruch: atakujący";
            else turnLabel.Text = "Ruch: obrońcy";

            if (!Battlefield.isAnyoneAlive(Battlefield.attackers) || !Battlefield.isAnyoneAlive(Battlefield.defenders))
            {
                if (Battlefield.isAnyoneAlive(Battlefield.attackers)) turnLabel.Text = "Wygrał atakujący.";
                else turnLabel.Text = "Wygrała obrona";

                Battlefield.isFight = false;
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
            if (!Battlefield.isFight)
                Battlefield.resolve(this);
        }

        private void switchSidesButton_Click(object sender, EventArgs e)
        {
            if (!Battlefield.isFight)
                Battlefield.switchSides(this);
        }
    }
}