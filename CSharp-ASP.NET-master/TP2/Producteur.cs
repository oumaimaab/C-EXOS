using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Producteur : Employe 
    {
        int nbUnit;
        public Producteur(string nom,string prenom,int age, int annee_rec,int nbUnit) : base(nom, prenom, age, annee_rec)
        {
            this.nbUnit = nbUnit;
        }

        public override double CalculSalaire()
        {
            return nbUnit*5;
        }

        public override string affiche()
        {
            return base.affiche()+" NbUnit = "+nbUnit;
            
        }
    }
}
