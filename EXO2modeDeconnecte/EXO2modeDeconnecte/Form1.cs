using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EXO2modeDeconnecte
{
    

    public partial class Form1 : Form
    {
        SqlConnection connx;
        DataTable student;
        SqlDataAdapter dap;
        DataTable filiere;

        
        public Form1()
        {
             InitializeComponent();
            string connection = " Data Source=DESKTOP-3HPS76H\\SQLEXPRESS; Initial Catalog=Etudiants; User Id=root; Password=; Integrated Security =true";
            connx = new SqlConnection();
            connx.ConnectionString = connection;
            Fill();


        }
        public void Fill()
        {
            //DataSet ds = new DataSet();
            student = new DataTable();
            dap = new SqlDataAdapter();
            filiere = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM etudiant", connx);
            dap.SelectCommand = cmd;
            dap.Fill(student);
            
            for(int i = 0; i< student.Rows.Count; i++)
            {
                comboBox1.Items.Add(student.Rows[i][0]);
            }
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Filiere", connx);
            dap.SelectCommand = cmd2;
            dap.Fill(filiere);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cne = comboBox1.SelectedItem.ToString();
            DataRow[] arr = student.Select("cne=" + cne+"");
            textBox1.Text = arr[0][1].ToString();
            textBox2.Text = arr[0][2].ToString();
            DataRow[] arr2 = filiere.Select("id_filiere=" + arr[0][5] + "");
            textBox3.Text = arr2[0][1].ToString();
        }

    }
}
