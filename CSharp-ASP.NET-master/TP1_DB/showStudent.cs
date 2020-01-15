using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TP1_DB
{
    public partial class ShowStudent : Form
    {
        SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
        DataSet ds = new DataSet();
        public ShowStudent()
        {
            InitializeComponent();
        }

        private void showStudent_Load(object sender, EventArgs e)
        {
            try
            {
                // mode connecte
                /*
                SqlCommand cmd = new SqlCommand("SELECT cne FROM Etudiant", dbCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    listCNE.Items.Add(dr[0].ToString());
                 */

                // mode deconnecte
                dbCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select cne from Etudiant",dbCon);
                adapter.Fill(ds, "Etudiant");
                foreach(DataRow item in ds.Tables["Etudiant"].Rows)
                    listCNE.Items.Add(item[0]);
               
                dbCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listCNE_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                // mode connecte
                /*
                SqlCommand cmd = new SqlCommand("SELECT nom,prenom,Nom_filiere FROM Etudiant e,Filiere f Where e.id_filiere=f.id_filiere and e.cne=@cne", dbCon);
                SqlParameter par = cmd.Parameters.Add("@cne", SqlDbType.VarChar);
                par.Direction = ParameterDirection.Input;
                par.Value = listCNE.SelectedItem;

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                StudentFirstName.Text = reader[0].ToString();
                StudentLastName.Text = reader[1].ToString();
                StudentFiliere.Text = reader[2].ToString();
                */


                // mode deconnecter
                dbCon.Open();

                MessageBox.Show(listCNE.SelectedItem.ToString());

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT nom,prenom,Nom_filiere FROM Etudiant e,filiere f Where e.id_filiere=f.id_filiere and e.cne='"+listCNE.SelectedItem+"'", dbCon);
                adapter.Fill(ds, "Etudiant_Filiere");
                DataRow item = ds.Tables["Etudiant_Filiere"].Rows[0]; //because it will return one row only
                StudentFirstName.Text = item[0] as string;
                StudentLastName.Text = item[1] as string;
                StudentFiliere.Text = item[2] as string;

                dbCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
