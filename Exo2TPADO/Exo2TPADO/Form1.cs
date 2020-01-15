using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2TPADO
{
    public partial class Form1 : Form
    {
        string connection = " Data Source=DESKTOP-3HPS76H\\SQLEXPRESS; Initial Catalog=Etudiants; User Id=root; Password=; Integrated Security =true";
        //string connection = "Server=.\\SQLExpress;Database=Etudiant;User Id=root; Password=; Integrated Security =true";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection;
            con.Open();

            string cne = comboBox1.SelectedItem.ToString();
            int id_fil=0;
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM etudiant WHERE (cne="+cne+")";
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read[0].ToString());
                textBox1.Text = read[1].ToString();
                textBox2.Text = read[2].ToString();
                id_fil = int.Parse(read[5].ToString());
            }
            read.Close();
            SqlCommand command2 = new SqlCommand("SELECT (Nom_Filiere) FROM Filiere WHERE (id_filiere='"+id_fil+")",con);
            SqlDataReader read2 = command.ExecuteReader();
            while (read2.Read())
            {
                textBox3.Text = read2.ToString();
            }
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(connection);
            con1.Open();
           // string cne = comboBox1.SelectedItem.ToString();
            SqlCommand command = con1.CreateCommand();
            command.CommandText = "SELECT * FROM etudiant";
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read[0].ToString());
                
            }
            
        }
    }
}
