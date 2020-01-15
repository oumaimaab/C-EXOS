using App.ServiceReference;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        Service1Client client;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Service1Client();
            filiereData.DataSource = client.GetFiliers();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            label.Text = client.Bonjour(textBox.Text);
            textBox.Text = "";
        }

        private void decrire_Click(object sender, EventArgs e)
        {
            Personne p = new Personne();
            p.Age = Int32.Parse(age.Text);
            p.Nom = nom.Text;
            p.Prenom = prenom.Text;
            personData.Text = client.DescriptionPersonne(p);
        }
    }
}
