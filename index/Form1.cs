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

    public partial class Form1 : Form
    {
        List<Button> buttonListAttacker;
        List<Button> buttonListDenfender;
        List<UnitView> unitViews;
        List<UnitView> unitViews2;
        int selected;
        public Form1()
        {
            InitializeComponent();

        }

        public int getSelected()
        {
            return this.selected;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selected = 0;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            unitViews = new List<UnitView>();
            unitViews.Add(new UnitView(unit1Button, unit1ProgressBar, unit1Number, unit1SizePicture));
            unitViews.Add(new UnitView(unit2Button, unit2ProgressBar, unit2Number, unit2SizePicture));
            unitViews.Add(new UnitView(unit3Button, unit3ProgressBar, unit3Number, unit3SizePicture));
            unitViews2 = new List<UnitView>();
            unitViews2.Add(new UnitView(unit4Button, unit4ProgressBar, unit4Number, unit4SizePicture));
            unitViews2.Add(new UnitView(unit5Button, unit5ProgressBar, unit5Number, unit5SizePicture));
            unitViews2.Add(new UnitView(unit6Button, unit6ProgressBar, unit6Number, unit6SizePicture));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selected = 2;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        public void refreshForm()
        {
            int i = 0;
            foreach(var unit in unitViews)
            {
                if(i<Battlefield.attacker.Count)
                {
                    unit.unitButton.Image = Battlefield.attacker[i].getImageUnit();
                    unit.number.Text = Battlefield.attacker[i].getNumber().ToString();
                    unit.size.Image = Battlefield.attacker[i].getUnitSizeImage();
                    if (unit.unitButton.Image != null && ((int)Battlefield.attacker[i].getOrgPercentage()) > 0) { unit.organization.Value = ((int)Battlefield.attacker[i].getOrgPercentage()); } else { unit.organization.Value = 0; }

                }
                i++;
            }
            i = 0;
            foreach (var unit in unitViews2)
            {
                if (i < Battlefield.defender.Count)
                {
                    unit.unitButton.Image = Battlefield.defender[i].getImageUnit();
                    unit.number.Text = Battlefield.defender[i].getNumber().ToString();
                    unit.size.Image = Battlefield.defender[i].getUnitSizeImage();
                    if (unit.unitButton.Image != null && ((int)Battlefield.defender[i].getOrgPercentage())>0) { unit.organization.Value = ((int)Battlefield.defender[i].getOrgPercentage()); } else { unit.organization.Value = 0; }

                }
                i++;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void unit5Button_Click(object sender, EventArgs e)
        {
            selected = 4;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void unit2Button_Click(object sender, EventArgs e)
        {
            selected = 1;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void unit4Button_Click(object sender, EventArgs e)
        {
            selected = 3;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void unit6Button_Click(object sender, EventArgs e)
        {
            selected = 5;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
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
    public class UnitView
    {
        public Button unitButton;
        public ProgressBar organization;
        public Label number;
        public PictureBox size;


        public UnitView(Button unitButton, ProgressBar organization, Label number, PictureBox size)
        {
            this.unitButton = unitButton;
            this.organization = organization;
            this.number = number;
            this.size = size;
        }

    }
}
