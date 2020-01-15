using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Forms;

namespace Service
{
    public class Service1 : IService1
    {
        public string Bonjour(string nom)
        {
            return "Bonjour "+nom;
        }

        public DataTable GetFiliers()
        {
            try
            {
                DataClasses1DataContext cl = new DataClasses1DataContext();
                var selectQuery = from a in cl.filiere select a;

                DataTable dt = new DataTable();

                foreach(var fil in selectQuery)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = fil.id_filiere;
                    dr[1] = fil.nom_filiere;
                    dt.Rows.Add(dr);
                }

                return dt;
           
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string DescriptionPersonne(Personne p)
        {
            string s = "Mme ou Mr " + p.Nom + " a " + p.Age + " ans ";
            return s;
        }

    }
}
