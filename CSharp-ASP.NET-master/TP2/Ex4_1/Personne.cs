using System;
using System.Collections;

namespace Ex4_1
{
    class Personne 
    { 
        string nom;
        string prenom;
        int age;

        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public string Nom { get => nom; set => nom = value; }

    }
}
