using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO6_TP2
{
    class Ville:IComparable<Ville>
    {
        private string nomVille, codeDepartement, codeCommune;

        public Ville(string nomVille, string codeDepartement, string codeCommune)
        {
            this.NomVille = nomVille;
            this.CodeDepartement = codeDepartement;
            this.CodeCommune = codeCommune;
        }

        public string NomVille { get => nomVille; set => nomVille = value; }
        public string CodeDepartement { get => codeDepartement; set => codeDepartement = value; }
        public string CodeCommune { get => codeCommune; set => codeCommune = value; }
        public int CompareTo(Ville ville)
        {
            return nomVille.CompareTo(ville.nomVille);
        }
    }
}
