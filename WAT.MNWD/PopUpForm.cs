using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using index.Properties;

namespace index
{
    public partial class PopUpForm : Form
    {
        private readonly MainForm mainForm;
        private UnitView _unitView;
        

        public PopUpForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            unitSizeComboBox.Items.AddRange(new object[]
            {
                UnitSize.Team,
                UnitSize.Platoon,
                UnitSize.Company,
                UnitSize.Battalion,
                UnitSize.Brigade
            });
            unitKind.Items.AddRange(new object[]
            {
                UnitKind.Infantry,
                UnitKind.Armoured,
                UnitKind.Recon,
                UnitKind.Artillery,
                UnitKind.Mechanized
            });
            unitKind.Enabled = false;
            unitSizeComboBox.Enabled = false;
            
            checkBoxNATO.Enabled = false;
            checkBoxCSTO.Enabled = false;


            if (mainForm.getSelected() < 3)
            {
                checkBoxNATO.Checked = false;
                checkBoxCSTO.Checked = true;
            }
            else
            {
                checkBoxNATO.Checked = true;
                checkBoxCSTO.Checked = false;
            }


        }
        public PopUpForm(MainForm mainForm, Unit unit) : this(mainForm)
        {
            unitNumber.Text = unit.IdentityNumber.ToString();
            unitNameLabel.Text = unit.Name;
            unitKind.SelectedIndex = (int) unit.UnitKind;
            unitSizeComboBox.Text = unit.Strength.ToString();

            if (!unit.Side)
            {
                checkBoxNATO.Checked = true;
                checkBoxCSTO.Checked = false;
            }
            else
            {
                checkBoxCSTO.Checked = true;
                checkBoxNATO.Checked = false;
            } 
                
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNATO.Checked && checkBoxCSTO.Checked)
                checkBoxCSTO.Checked = false;
            else if (unitKind.Enabled == false) unitKind.Enabled = true;
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCSTO.Checked && checkBoxNATO.Checked)
                checkBoxNATO.Checked = false;
            else if (unitKind.Enabled == false) unitKind.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (unitSizeComboBox.SelectedIndex)
            {
                case 0:
                    pictureSize.Image = Resources.Team;
                    break;
                case 1:
                    pictureSize.Image = Resources.Platoon;
                    break;
                case 2:
                    pictureSize.Image = Resources.Company;
                    break;
                case 3 :
                    pictureSize.Image = Resources.Battalion_f1;
                    break;
                case 4:
                    pictureSize.Image = Resources.Brigade;
                    break;
            }
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
            if (Regex.IsMatch(unitNameLabel.Text, "^[AaĄąBbCcĆćDdEeĘęFfGgHhIiJjKkLlŁłMmNnŃńOoÓóPpRrSsŚśTtUuWwYyssssssdqddwqqqqqaaaaaZzŹźŻżXxQqVv0-9 ]*$"))
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
            if(checkBoxCSTO.Checked)
            {
                switch (unitKind.SelectedIndex)
                {

                    case 0:
                        pictureType.Image = Resources.hostile_infantry;
                        break;
                    case 1:
                        pictureType.Image = Resources.hostile_armour;
                        break;
                    case 2:
                        pictureType.Image = Resources.hostile_recon;
                        break;
                    case 3:
                        pictureType.Image = Resources.hostile_artillery;
                        break;
                    case 4:
                        pictureType.Image = Resources.hostile_mechanized;
                        break;
                }
            }else
                switch (unitKind.SelectedIndex)
                {

                    case 0:
                        pictureType.Image = Resources.nato_infantry;
                        break;
                    case 1:
                        pictureType.Image = Resources.nato_armoured;
                        break;
                    case 2:
                        pictureType.Image = Resources.nato_recon;
                        break;
                    case 3:
                        pictureType.Image = Resources.nato_artilery;
                        break;
                    case 4:
                        pictureType.Image = Resources.nato_mechanized;
                        break;
                }
            
            if (unitKind.Enabled) unitSizeComboBox.Enabled = true;
        }

        private void saveUnitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unitNumber.Text) || string.IsNullOrEmpty(unitSizeComboBox.Text) ||
                string.IsNullOrEmpty(unitNameLabel.Text) || string.IsNullOrEmpty(unitKind.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool side;
            Unit unit = new Unit();
            if(checkBoxNATO.Checked)
            {
                side = false;
            }
            else
            {
                side = true;
            }
            switch (unitKind.SelectedIndex)
            {
                case 0:
                    unit = new Infantry(unitNameLabel.Text,int.Parse(unitNumber.Text), side, (UnitSize) unitSizeComboBox.SelectedIndex);
                    break;
                case 1:
                    unit = new Armoured(unitNameLabel.Text,int.Parse(unitNumber.Text), side, (UnitSize) unitSizeComboBox.SelectedIndex);
                    break;
                case 2:
                    unit = new Recon(unitNameLabel.Text,int.Parse(unitNumber.Text), side, (UnitSize) unitSizeComboBox.SelectedIndex);
                    break;
                case 3:
                    unit = new Artillery(unitNameLabel.Text,int.Parse(unitNumber.Text), side, (UnitSize) unitSizeComboBox.SelectedIndex);
                    break;
                case 4:
                    unit = new Mechanized(unitNameLabel.Text,int.Parse(unitNumber.Text), side, (UnitSize) unitSizeComboBox.SelectedIndex);
                    break;
            }

            //UnitsInFormCounter can be greater than 6
            if (mainForm.getSelected() < 3)
            {
                Battlefield.attackers[mainForm.getSelected()] = unit;
                mainForm.UnitsInFormCounter++;
            }
            else
            {
                Battlefield.defenders[mainForm.getSelected() - 3] = unit;
                mainForm.UnitsInFormCounter++;
            }

            mainForm.refreshForm();
            Close();
        }

        private void cancelUnitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}