using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO3_TP2
{
    class Personne:IComparable<Personne>
    {
        private string nom, prenom;
        private int age;

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Age = age;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }

        public int CompareTo(Personne personne)
        {
            return nom.CompareTo(personne.nom);
        }

    }
}
