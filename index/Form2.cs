using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
            this.unitSizeComboBox.Items.AddRange(new object[] 
            {           
                        "Team",
                        "Platoon",
                        "Company",
                        "Battalion",
                        "Brigade"
            });
            this.comboBox2.Items.AddRange(new object[]
            {
                        "Infantry",
                        "Armoured",
                        "Recon",
                        "Artillery",
                        "Mechanized"
            });
            comboBox2.Enabled = false;
        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            else if (comboBox2.Enabled == false)
            {
                comboBox2.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }else if(comboBox2.Enabled == false)
            {
                comboBox2.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(unitSizeComboBox.SelectedIndex == 0)
            {
                pictureSize.Image = Properties.Resources.Team;
            }else if(unitSizeComboBox.SelectedIndex == 1)
            {
                pictureSize.Image = Properties.Resources.Platoon;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(unitNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Wprowadz liczbe.");
                unitNumber.Text = unitNumber.Text.Remove(unitNumber.Text.Length - 1);
            }else
            {
                label4.Text = unitNumber.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureSize_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 4)
            {
                pictureType.Image = Properties.Resources.nato_mechanized;
            }

        }

        private void saveUnitButton_Click(object sender, EventArgs e)
        {
            Mechanized unit = new Mechanized(unitNameLabel.Text,unitSizeComboBox.Text,true,Int16.Parse(unitNumber.Text));
            Battlefield.attacker[f1.getSelected()] = unit;
            f1.refreshForm();
            this.Close();
        }
    }
}
