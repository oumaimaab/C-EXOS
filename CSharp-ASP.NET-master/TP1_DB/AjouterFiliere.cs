using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace TP1_DB
{
    public partial class AjouterFiliere : Form
    {
        SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
        DataSet ds = new DataSet();
        public AjouterFiliere()
        {
            InitializeComponent();
        }

        private void addFiliere_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Filiere(Nom_filiere) VALUES (@nom)", dbCon);
                
                SqlParameter par = cmd.Parameters.Add("@nom", SqlDbType.VarChar);
                par.Direction = ParameterDirection.Input;
                par.Value = filiereNameInput.Text;

                cmd.ExecuteNonQuery();

                filiereNameInput.Text = "";

                MessageBox.Show("Filiere Bien Ajouter");
                dbCon.Close();
            }catch(SqlException ex){
                MessageBox.Show(ex.Message);
            }

        }
    }
}
