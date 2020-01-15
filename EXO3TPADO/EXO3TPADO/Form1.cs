using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace EXO3TPADO
{
    public partial class Form1 : Form
    {
        String connection = "Data Source=DESKTOP-3HPS76H\\SQLEXPRESS; Initial Catalog=Compte; User Id=root; Password=; Integrated Security =true";
        SqlConnection cnx = new SqlConnection();
        DataClasses1DataContext comptes = new DataClasses1DataContext();
        DataSet comptesSet;
        DataTable dataTable;
        DataRow[] table1,table2;
        SqlDataAdapter dap;
        public Form1()
        {
            InitializeComponent();
            cnx.ConnectionString = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string client1Num = textBox1.Text;
            string client2Num = textBox2.Text;
            var soldeClien1 = (from compte in comptes.Comptes where compte.Num.Equals(Int32.Parse(client1Num)) select compte).SingleOrDefault();
            var soldeClien2 = (from compte in comptes.Comptes where compte.Num.Equals(Int32.Parse(client2Num)) select compte).SingleOrDefault();

            textBox3.Text = soldeClien1.solde.ToString();
            textBox4.Text = soldeClien2.solde.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int montant = Int32.Parse(textBox5.Text);
            cnx.Open();
            SqlTransaction transaction = cnx.BeginTransaction();
            SqlCommand commande = cnx.CreateCommand();
            commande.Transaction = transaction;
            try
            {
                if (montant > Int32.Parse(textBox3.Text))
                {
                    transaction.Rollback();
                    MessageBox.Show("Fin awa ghadi");
                    
                }
                else
                {
                    int solde1 = Int32.Parse(textBox3.Text) - montant;
                    int solde2 = Int32.Parse(textBox4.Text) + montant;
                    commande.CommandText="UPDATE compte SET solde='"+solde1+"'WHERE num='"+ Int32.Parse(textBox1.Text)+"'";
                    commande.ExecuteNonQuery();
                    commande.CommandText = "UPDATE compte SET solde='" + solde2 + "'WHERE num='" + Int32.Parse(textBox2.Text) + "'";
                    commande.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Transaction effectuer");
                    textBox3.Text = solde1.ToString();
                    textBox4.Text = solde2.ToString();
                }

            }
            catch(Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);

            }
            cnx.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int montant = Int32.Parse(textBox5.Text);
            cnx.Open();
            using (var scope = new TransactionScope())
            {
                if (montant > Int32.Parse(textBox3.Text))
                {
                    scope.Dispose();
                    MessageBox.Show("Fin awa ghadi");

                }
                else
                {
                    int solde1 = Int32.Parse(textBox3.Text) - montant;
                    int solde2 = Int32.Parse(textBox4.Text) + montant;
                    int len = comptesSet.Tables["compte"].Rows.Count;
                    for(int i = 0; i < len; i++)
                    {
                        if (comptesSet.Tables["compte"].Rows[i][0].ToString().Equals(textBox1.Text))
                        {
                            comptesSet.Tables["compte"].Rows[i][3] = solde1;
                            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dap);
                            dap.Update(comptesSet.Tables["compte"]);

                        }
                        if (comptesSet.Tables["compte"].Rows[i][0].ToString().Equals(textBox2.Text))
                        {
                            comptesSet.Tables["compte"].Rows[i][3] = solde2;
                            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dap);
                            dap.Update(comptesSet.Tables["compte"]);

                        }
                    }
                    scope.Complete();
                    MessageBox.Show("Transaction effectuer");
                    textBox3.Text = solde1.ToString();
                    textBox4.Text = solde2.ToString();
                }
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            comptesSet = new DataSet();
            dap = new SqlDataAdapter("SELECT * FROM compte", cnx);
            dap.Fill(comptesSet, "compte");
            table1 = comptesSet.Tables["compte"].Select("Num=" + textBox1.Text);
            textBox3.Text = table1[0][3].ToString();
            table2 = comptesSet.Tables["compte"].Select("Num=" + textBox2.Text);
            textBox4.Text = table2[0][3].ToString();

        }
    }
}
