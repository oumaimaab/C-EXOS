using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Employe
    {
        string nom;
        string prenom;
        int age;
        int annee_rec;

        public Employe(string nom, string prenom, int age, int annee_rec)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.annee_rec = annee_rec;
        }

        public virtual string affiche()
        {
            return "Nom : " + nom+ " Prenom : " + prenom+" Age : " + age+" Année de recrutement : " + annee_rec;

        }

        public virtual double CalculSalaire()
        {
            return 4;
        }
    }
}
