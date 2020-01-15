using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO5_TP2
{
    class Personne:IComparable<Personne>
    {
        private string nom, prenom;
        private int age;

        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }

        public int Age { get => age; set => age = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public int CompareTo(Personne personne)
        {
            return nom.CompareTo(personne.Nom);
        }
    }
}
