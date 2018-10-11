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
        public static int licznik = 1;
        List<kryteriaClass> listaKryteriow = new List<kryteriaClass>();
        List<TextBox> textBoxList = new List <TextBox>();
        ListView listV;
        private void createTextBox()
        {
            TextBox textBoxAdd = new TextBox();
            textBoxAdd.Location = new Point(80, licznik * 25);
            textBoxAdd.Name = "kryterium" + licznik;
            Label labelBoxAdd = new Label();
            labelBoxAdd.Text = "Kryterium " + licznik;
            labelBoxAdd.Width = 70;
            labelBoxAdd.Location = new Point(10, licznik * 25);
            textBoxList.Add(textBoxAdd);
            this.Controls.Add(labelBoxAdd);
            this.Controls.Add(textBoxAdd);
            licznik++;
            listaKryteriow.Add(new kryteriaClass(licznik, textBoxAdd.Text));
        }
        public wpisanieDanych(kryteriaClass k, List<kryteriaClass> listaKryteriowForm, ListView listView)
        {
            listV = listView;
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
            foreach (TextBox t in textBoxList)
            {
                listaKryteriow.Add(new kryteriaClass(licznik, t.Text));
                listView1.Items.Add(t.Text);
            }
            listView1 = listV;
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createTextBox();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
