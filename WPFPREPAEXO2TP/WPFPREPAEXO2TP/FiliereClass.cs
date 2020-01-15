using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPREPAEXO2TP
{

    public class FiliereClass : IDataErrorInfo
    {
        private int id;
        private string nomFil;
        private string responsable;
        public string this[string columnName]
        {
            get
            {
                string res = null;
                if (columnName == "NomFil")
                {
                    if (string.IsNullOrEmpty(NomFil) || NomFil=="")
                    {
                        res = "Entrer un nom";

                    }
                }
                return res;
            }
        }

        public string Error => throw new NotImplementedException();

        public string Responsable { get => responsable; set => responsable = value; }
        public string NomFil { get => nomFil; set => nomFil = value; }
        public int Id { get => id; set => id = value; }
    }
}
