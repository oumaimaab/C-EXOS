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

namespace TP1_DB
{
    public partial class CompteBanque : Form
    {
        SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
        DataSet ds = new DataSet();
        public CompteBanque()
        {
            InitializeComponent();
        }


        private void makeVirement_Click(object sender, EventArgs e)
        {
            dbCon.Open();
             SqlTransaction transaction = dbCon.BeginTransaction();
            try
            {
                SqlCommand cmd1 = new SqlCommand("Update Compte set solde=solde-@solde where Num=1;", dbCon,transaction);
                SqlCommand cmd2 = new SqlCommand("Update Compte set solde=solde+@solde where Num=2", dbCon,transaction);
                SqlParameter par1 = cmd1.Parameters.Add("@solde", SqlDbType.BigInt);
                SqlParameter par2 = cmd2.Parameters.Add("@solde", SqlDbType.BigInt);
                par1.Direction = par2.Direction = ParameterDirection.Input;
                par1.Value = par2.Value = montantDeposer.Text;

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                montantDeposer.Text = "";

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("There was an error");
            }

            dbCon.Close();
        }

        private void afficherSolde_Click(object sender, EventArgs e)
        {
            // mode connecter
            //sClient1.Text = GetCompteSolde(int.Parse(nClient1.Text));
            //sClient2.Text = GetCompteSolde(int.Parse(nClient2.Text));

            // mode deconnecter
            try
            {
                dbCon.Open();
                if(ds.Tables["Compte"] != null)
                {
                    ds.Tables["Compte"].Clear();
                }

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Compte", dbCon);
                adapter.Fill(ds, "Compte");
                
                sClient1.Text = GetCompteSoldeDeconnecter(int.Parse(nClient1.Text));
                sClient2.Text = GetCompteSoldeDeconnecter(int.Parse(nClient2.Text));
                dbCon.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string GetCompteSolde(int num)
        {
            SqlDataReader reader = null;
            try
            {
                dbCon.Open();
                // command for client 1

                SqlCommand cmd1 = new SqlCommand("SELECT solde FROM Compte Where Num=@num", dbCon);

                SqlParameter par = cmd1.Parameters.Add("@num", SqlDbType.Int);
                par.Direction = ParameterDirection.Input;
                par.Value = num;

                reader = cmd1.ExecuteReader();
                reader.Read();

                return reader[0].ToString();

            }
            catch(SqlException e)
            {
                MessageBox.Show( e.Message);
                return null;
            }
            finally
            {
                dbCon.Close();
                reader.Close();
            }
        }

        public string GetCompteSoldeDeconnecter(int num)
        {
            string founded = null;
            foreach (DataRow row in ds.Tables["Compte"].Rows)
            {
                if ((int)row[0] == num)
                {
                    founded = "" + row[1];
                    break;
                }
                    
            }
           return founded;
            
        }

        private void CompteBanque_Load(object sender, EventArgs e)
        {

        }
    }

}
