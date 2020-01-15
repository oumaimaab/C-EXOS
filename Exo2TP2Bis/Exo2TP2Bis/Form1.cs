using EXO1_TP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2TP2Bis
{
    public partial class Form1 : Form
    {
        Producteur e1 = new Producteur("Arbani", "Oumaima", 20, 2016,20);
        Personnel p1 = new Personnel();
        public Form1()
        {
            InitializeComponent();
            List_du_personnel_Button.Click += new EventHandler(List_du_personnel_Button_Click);            ;
        }

        private void List_du_personnel_Button_Click(object sender, EventArgs e)
        {
           
            p1.AjouterEmploye(e1);
            listBox1.Items.Add(p1.Show());
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salaire_Moyen_Click(object sender, EventArgs e)
        {
            textBoxSalaire.Text = p1.SalaireMoyen().ToString();
        }

        private void NombreEmploye_Click(object sender, EventArgs e)
        {
            textBoxNbEmp.Text = p1.NbEmploye();
        }
    }
}
