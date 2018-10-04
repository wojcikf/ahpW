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
    public partial class wpisanieDanych : Form
    {
        public int kryteria;
        public int argumenty;
        List<kryteriaClass> nazwyKryteriow = new List<kryteriaClass>();
        public wpisanieDanych(kryteriaAlternatywyClass k)
        {

            this.kryteria = k.iloscKryteriow;
            this.argumenty = k.iloscAlternatyw;

            for (int i = 1; i <= kryteria; i++) {

                TextBox textBoxAdd = new TextBox();
                textBoxAdd.Location = new Point(80, i * 25 );
                textBoxAdd.Name = "kryterium" + i;
                Label labelBoxAdd = new Label();
                labelBoxAdd.Text = "Kryterium " + i;
                labelBoxAdd.Width = 70;
                labelBoxAdd.Location = new Point(10, i * 25);

                this.Controls.Add(labelBoxAdd);
                this.Controls.Add(textBoxAdd);

                nazwyKryteriow.Add(new kryteriaClass(i, textBoxAdd.Text));


            }

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TextBox btnAdd = new TextBox();
            this.Controls.Add(btnAdd);
      
        }

        private void wpisanieDanych_Load(object sender, EventArgs e)
        {

        }

        private void zapiszKryteria_Click(object sender, EventArgs e)
        {

        }
    }
}
