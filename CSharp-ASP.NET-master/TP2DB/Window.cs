using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2DB
{
    public partial class mainWindow : Form
    {
        SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
        DataSet ds = new DataSet();
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                dbCon.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select cne,nom,prenom,sexe,date_naiss from Etudiant", dbCon);
                adapter.Fill(ds, "Etudiants");
                foreach (DataRow item in ds.Tables["Etudiants"].Rows)
                    listCneSelect.Items.Add(item[0]);

                studentsTable.DataSource = ds.Tables["Etudiants"];

                dbCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listCneSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbCon.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select cne,nom,prenom,sexe,date_naiss from Etudiant where cne='"+listCneSelect.SelectedItem+"'", dbCon);
                adapter.Fill(ds, "Etudiant");
                foreach (DataRow item in ds.Tables["Etudiant"].Rows)
                    listCneSelect.Items.Add(item[0]);

                studentsTable.DataSource = ds.Tables["Etudiant"];

                dbCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
