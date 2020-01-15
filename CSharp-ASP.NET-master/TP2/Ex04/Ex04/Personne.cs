using System;

namespace Ex04
{
    class Personne : IComparable
    { 
        string nom;
        string prenom;
        int age;

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Personne p = obj as Personne;
            if (p != null)
                 return string.Compare(nom,p.nom,StringComparison.CurrentCulture);
            else
                throw new ArgumentException("Object is not a Personne");
             
        }
    }
}
