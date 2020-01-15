using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Ville
    {
        private String nomVille;
        private String codeDepartement;
        private String codeCommune;

        public Ville(string nomVille, string codeDepartement, string codeCommune)
        {
            this.NomVille = nomVille;
            this.codeDepartement = codeDepartement;
            this.codeCommune = codeCommune;
        }

        public string NomVille { get => nomVille; set => nomVille = value; }

        public override bool Equals(object obj)
        {
            return obj is Ville ville &&
                   NomVille == ville.NomVille &&
                   codeDepartement == ville.codeDepartement &&
                   codeCommune == ville.codeCommune;
        }

        public override string ToString()
        {
            return "Ville : "+NomVille + " codeDepartement : " + codeDepartement + " codeCommune : " + codeCommune;
        }
    }
}
