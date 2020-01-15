using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO4_TP2
{
    class Personne
    {
        private string nom, prenom;
        private int age;

        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }

        
    }
}
