using System;

namespace ex03
{
    public enum Ville {Safi, Marrakech, Rabat, Casa}
    class Personne
    {
        private string nom;
        private string prenom;
        public int age;
        public string tel;
        public Ville ville;

        public string Nom { get => nom; }
        public string Prenom { get => prenom; }

        public Personne()
        {
            Console.WriteLine("Construction de classe personne");
        }
        public Personne(string nom, string prenom, int age, string tel,Ville v)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.tel = tel;
            ville = v;
        }
        Personne(Personne p)
        {
            nom = p.Nom;
            prenom = p.Prenom;
            age = p.age;
            tel = p.tel;
        }

        public static void changePersonne(int ancien_age)
        {
            age = ancien_age;
        }

        public void SavoirOrigine()
        {
            switch (ville)
            {
                case Ville.Marrakech: Console.WriteLine("cette personne est d'origine de Marrakech");
                case Ville.Casa: Console.WriteLine("cette personne est d'origine de Casa");
                case Ville.Safi: Console.WriteLine("cette personne est d'origine de Safi");
                case Ville.Rabat: Console.WriteLine("cette personne est d'origine de Rabat");
            }
        }

        static void Main(string[] args)
        {
            Personne p1 = new Personne("oussidi", "mohamed", 21, "547657");
            Personne p2 = p1;

            Console.ReadLine();

        }
    }

}