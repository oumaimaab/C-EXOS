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

namespace TP_ADO_exo2_connecte
{
    public partial class Form1 : Form
    {
        string connection = " Data Source=DESKTOP-3HPS76H\\SQLEXPRESS; Initial Catalog=Etudiants; User Id=root; Password=; Integrated Security =true";
        DataSet ds ;
        DataTable students,filiere;
        SqlDataAdapter dataAdapter;
        SqlConnection cnx = new SqlConnection();
        public Form1()
        {
            //string connection= " Data Source=DESKTOP-3HPS76H\\SQLEXPRESS; Initial Catalog=Etudiants; User Id=root; Password=; Integrated Security =true";
            InitializeComponent();
            cnx.ConnectionString = connection;
            Fill();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Fill()
        {
            cnx.ConnectionString = connection;

            /*Mode deconnecté*/
            ds = new DataSet();
            students = new DataTable();
            filiere = new DataTable();
            dataAdapter = new SqlDataAdapter("SELECT * FROM etudiant", cnx);
            dataAdapter.Fill(ds, "students");
            comboBox1.DataSource = ds.Tables["students"];
            comboBox1.ValueMember = "cne";
            comboBox1.DisplayMember = "cne";
            //dataAdapter.Fill(students);
            //for(int i = 0; i < students.Rows.Count; i++)
            //{
             //   comboBox1.Items.Add(students.Rows[i][0]);
            //}
            //dataAdapter = new SqlDataAdapter("SELECT * FROM filiere", cnx);
            //dataAdapter.Fill(filiere);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.ConnectionString = connection;
            comboBox1.SelectedIndex = -1;

            string cne = comboBox1.SelectedItem.ToString();
            DataRow[] arr = ds.Tables["students"].Select("cne="+cne);
            textBox1.Text = arr[0][1].ToString();
            textBox2.Text = arr[0][2].ToString();
            //DataRow[] arr2 = filiere.Select("id_filiere=" + arr[0][5] + "");
            //textBox3.Text = arr2[0][1].ToString();


            //Mode connecté
            /*
            string cneSelected = comboBox1.SelectedItem.ToString();
            int idFil = 0;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connection;
            

            SqlCommand command = cnx.CreateCommand();
            string sql = "SELECT * FROM etudiant WHERE cne="+cneSelected;
            command.CommandText = sql;

            cnx.Open();

            SqlDataReader readData = command.ExecuteReader();
            while (readData.Read())
            {

                textBox1.Text = readData[1].ToString();
                textBox2.Text = readData[2].ToString();
                idFil =Int32.Parse(readData[5].ToString());
            }
            readData.Close();
            SqlCommand cmd = cnx.CreateCommand();
            string req = "SELECT Nom_filiere FROM Filiere WHERE Id_filiere=@filiere";
            SqlParameter parameter = new SqlParameter("@filiere", idFil);
            cmd.Parameters.Add(parameter);
            cmd.CommandText = req;
            SqlDataReader read1 = cmd.ExecuteReader();
            while (read1.Read())
            {
                textBox3.Text = read1[0].ToString();
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            


            /*Mode connecté*/
            /*****************************************
            SqlCommand command = cnx.CreateCommand();
            string sql = "SELECT cne FROM etudiant";
            command.CommandText = sql;

            cnx.Open();

            SqlDataReader readData = command.ExecuteReader();
            while (readData.Read())
            {
                comboBox1.Items.Add(readData[0].ToString());
            }
            ******/
            /*****************************************/

        }
    }
}
