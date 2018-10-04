using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wojcikAhp
{
    public partial class Form1 : Form
    {
       kryteriaAlternatywyClass k = new kryteriaAlternatywyClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wpisanieDanych w = new wpisanieDanych(k);
            w.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            k.iloscKryteriow = (int)numericUpDown1.Value;
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            k.iloscAlternatyw = (int)numericUpDown1.Value;
        }
    }
}
