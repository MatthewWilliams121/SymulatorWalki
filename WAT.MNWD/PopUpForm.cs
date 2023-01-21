﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using index.Properties;

namespace index
{
    public partial class PopUpForm : Form
    {
        private readonly MainForm mainForm;

        public PopUpForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            unitSizeComboBox.Items.AddRange(new object[]
            {
                "Team",
                "Platoon",
                "Company",
                "Battalion",
                "Brigade"
            });
            unitKind.Items.AddRange(new object[]
            {
                "Infantry",
                "Armoured",
                "Recon",
                "Artillery",
                "Mechanized"
            });
            unitKind.Enabled = false;
        }

        private void PopUpFormLoad(object sender, EventArgs e)
        {
            checkBoxNATO.Enabled = false;
            checkBoxCSTO.Enabled = false;

            if (mainForm.getSelected() < 3)
                checkBoxNATO.Checked = true;
            else
                checkBoxCSTO.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNATO.Checked && checkBoxCSTO.Checked)
                checkBoxCSTO.Checked = false;
            else if (unitKind.Enabled == false) unitKind.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCSTO.Checked && checkBoxNATO.Checked)
                checkBoxNATO.Checked = false;
            else if (unitKind.Enabled == false) unitKind.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unitSizeComboBox.SelectedIndex == 0)
                pictureSize.Image = Resources.Team;
            else if (unitSizeComboBox.SelectedIndex == 1) pictureSize.Image = Resources.Platoon;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        //Unit identityNumber
        private void UnitNumber_textChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(unitNumber.Text, "^[0-9]*$")) //dodac walidacje 0 na poczatku
            {
                label4.Text = unitNumber.Text;
            }
            else
            {
                if(unitNumber.Text.Length >0)
                    unitNumber.Text = unitNumber.Text.Remove(unitNumber.Text.Length - 1);
                MessageBox.Show("Dopuszczalne są tylko cyfry.", "Ostrzeżenie", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Unit name
        private void UnitName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(unitNameLabel.Text, "^[a-zA-Z0-9 ]*$"))
            {
                captionUnitName.Text = unitNameLabel.Text;
            }
            else
            {
                unitNameLabel.Text = unitNameLabel.Text.Remove(unitNameLabel.Text.Length - 1);
                MessageBox.Show("Dopuszczalne są tylko cyfry i litery.", "Ostrzeżenie", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void pictureSize_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unitKind.SelectedIndex == 4) pictureType.Image = Resources.nato_mechanized;
        }

        private void saveUnitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unitNumber.Text) || string.IsNullOrEmpty(unitSizeComboBox.Text) ||
                string.IsNullOrEmpty(unitNameLabel.Text) || string.IsNullOrEmpty(unitKind.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // var unit = new Mechanized(unitNameLabel.Text, unitSizeComboBox.Text, true,
                // short.Parse(unitNumber.Text)); // TO OGARNIJ WOJTEK

            Unit unit = new Unit();

            switch (unitKind.SelectedIndex)
            {
                case 0:
                    unit = new Infantry(unitNameLabel.Text, unitSizeComboBox.Text, true,
                        short.Parse(unitNumber.Text));
                    break;
                case 1:
                    // unit = new Armoured(unitNameLabel.Text, unitSizeComboBox.Text, true,
                    //     short.Parse(unitNumber.Text));
                    break;
                case 2:
                    // unit = new Recon(unitNameLabel.Text, unitSizeComboBox.Text, true,
                    //     short.Parse(unitNumber.Text));
                    break;
                case 3:
                    // unit = new Artillery(unitNameLabel.Text, unitSizeComboBox.Text, true,
                    //     short.Parse(unitNumber.Text));
                    break;
                case 4:
                    unit = new Mechanized(unitNameLabel.Text, unitSizeComboBox.Text, true,
                        short.Parse(unitNumber.Text));
                    break;
            }

            Console.Out.WriteLine(unit.Name);
            if (mainForm.getSelected() < 3)
                Battlefield.attacker[mainForm.getSelected()] = unit;
            else
                Battlefield.defender[mainForm.getSelected() - 3] = unit;

            mainForm.refreshForm();
            Close();
        }

        private void cancelUnitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}