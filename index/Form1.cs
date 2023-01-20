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
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void refreshForm()
        {
            unit1Button.Image = Battlefield.attacker[0].getImageUnit();
            unit1Number.Text = Battlefield.attacker[0].getNumber().ToString();
            unit1SizePicture.Image = Battlefield.attacker[0].getUnitSizeImage();
            unit1ProgressBar.Value = 100; // Procent
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void unit5Button_Click(object sender, EventArgs e)
        {

        }
    }
}
