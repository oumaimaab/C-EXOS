using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Form1 : Form
    {
        Personell p = new Personell();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<string> list = p.getPersonnel();
            ListPersonnel.Items.Clear();
            foreach (string item in list)
            {
                ListPersonnel.Items.Add(item);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = p.salaireMoyen().ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = p.NbEmployes().ToString();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Employe em = new Producteur(textBox3.Text, textBox4.Text,int.Parse(textBox5.Text),2019, int.Parse(textBox6.Text));
            p.ajouterEmploye(em);
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Producteur_Click(object sender, EventArgs e)
        {

        }

        private void AjouterVendeur_Click(object sender, EventArgs e)
        {
            Employe em = new Vendeur(textBox10.Text, textBox9.Text, int.Parse(textBox8.Text), 2019, int.Parse(textBox7.Text));
            p.ajouterEmploye(em);
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void AjouterRep_Click(object sender, EventArgs e)
        {
            Employe em = new Representant(textBox14.Text, textBox13.Text, int.Parse(textBox12.Text), 2019, int.Parse(textBox11.Text));
            p.ajouterEmploye(em);
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
