using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TP_Deconnecter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        public static int cpt;
        // procedure de navigation
        public void NAVIGATION()
        {
            txtref.Text = d.ds.Tables["produit"].Rows[cpt][0].ToString();
            txtdes.Text = d.ds.Tables["produit"].Rows[cpt][1].ToString();
            txtqte.Text = d.ds.Tables["produit"].Rows[cpt][2].ToString();
            comboBox1.Text = d.ds.Tables["produit"].Rows[cpt][3].ToString();
        }
      
        
        public void RemplirGrid()
        {
            if (d.ds.Tables["produit"] != null)
            {
                d.ds.Tables["produit"].Clear();
            }
            d.dap = new SqlDataAdapter("select * from PRODUIT", d.con);
            d.dap.Fill(d.ds, "produit");
            dataGridView1.DataSource = d.ds.Tables["produit"];
        }
        // Remplissage de combobox
        public void RemplirCombo()
        {
            comboBox1.Items.Clear();
            d.dap = new SqlDataAdapter("select * from CATEGORIE", d.con);
            d.dap.Fill(d.ds, "cat");
            comboBox1.DataSource = d.ds.Tables["cat"];
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "IDCAT";
        }

      







        

        // METHODE VIDER
        public void VIDER(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.GetType() == typeof(ComboBox))
                {
                    ct.ResetText();
                }
                if (ct.Controls.Count != 0)
                {
                    VIDER(ct);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                d.DECONNECTER();
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vider les champs?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            RemplirCombo();
            RemplirGrid();
           
           
        
           
         
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtref.Text == "" || txtdes.Text == "" || txtqte.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            d.ligne = d.ds.Tables["produit"].NewRow();
            d.ligne[0] = txtref.Text;
            d.ligne[1] = txtdes.Text;
            d.ligne[2] = txtqte.Text;
            d.ligne[3] = comboBox1.SelectedValue;
            for (int i = 0; i < d.ds.Tables["produit"].Rows.Count; i++)
            {
                if (txtref.Text == d.ds.Tables["produit"].Rows[i][0].ToString())
                {
                    MessageBox.Show("Produit existe déja");
                    return;
                }
            }
            d.ds.Tables["produit"].Rows.Add(d.ligne);
            MessageBox.Show("Produit ajouter avec succes");
            dataGridView1.DataSource = d.ds.Tables["produit"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtref.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            bool tr = false;
            for (int i = 0; i < d.ds.Tables["produit"].Rows.Count; i++)
            {
                if (txtref.Text == d.ds.Tables["produit"].Rows[i][0].ToString())
                {
                    tr = true;
                    d.ds.Tables["produit"].Rows[i].Delete();
                    MessageBox.Show("Produit supprimer déja");
                    dataGridView1.DataSource = d.ds.Tables["produit"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("Produit n'existe pas");
            }
        }
          

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtref.Text == "" || txtdes.Text == "" || txtqte.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            bool tr = false;
            for (int i = 0; i < d.ds.Tables["produit"].Rows.Count; i++)
            {
                if (txtref.Text == d.ds.Tables["produit"].Rows[i][0].ToString())
                {
                    tr = true;
                    d.ds.Tables["produit"].Rows[i][1] = txtdes.Text;
                    d.ds.Tables["produit"].Rows[i][2] = txtqte.Text;
                    d.ds.Tables["produit"].Rows[i][3] = comboBox1.SelectedValue;
                    MessageBox.Show("Produit modifier déja");
                    dataGridView1.DataSource = d.ds.Tables["produit"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("Produit n'existe pas");
            }
         }

        private void button6_Click(object sender, EventArgs e)
        {
          

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cpt = 0;
            NAVIGATION();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cpt = d.ds.Tables["produit"].Rows.Count - 1;
            NAVIGATION();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                cpt++;
                NAVIGATION();
            }
            catch
            {
                MessageBox.Show("vous etes sur le dernier enregistrement");
                cpt--;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                cpt--;
                NAVIGATION();
            }
            catch
            {
                MessageBox.Show("vous etes sur le premier enregistrement");
                cpt++;

            }
           
        }
        }
    }

