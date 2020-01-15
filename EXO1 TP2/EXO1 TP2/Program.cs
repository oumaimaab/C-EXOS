using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO1_TP2
{
    class Employe
    {
        private String nom, prenom;
        private int age,anneeDeRecrutement;
        public Employe(String nom,String prenom,int age,int anneeDeRecrutement)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.anneeDeRecrutement = anneeDeRecrutement;
        }
        public virtual void Affiche()
        {
            Console.WriteLine("Le nom est : " + this.nom);
            Console.WriteLine("Le prenom est : " + this.prenom);
            Console.WriteLine("L'age est : " + this.age);
            Console.WriteLine("L'annee de recrutement est : " + this.anneeDeRecrutement);
        }
        public virtual double CalculSalaire()
        {
            return 0;
        }
    }
    class Producteur:Employe
    {
        private int nbUnite;
        public Producteur(String nom, String prenom, int age, int anneeDeRecrutement,int nbUnite) :base(nom, prenom, age, anneeDeRecrutement)
        {
            this.nbUnite = nbUnite;
        }
        public override double CalculSalaire()
        {
            return this.nbUnite * 5;
        }
        public override void Affiche()
        {
            base.Affiche();
            Console.WriteLine("Le salaire du prodecteur est : " + this.CalculSalaire());
        }
    }
    class Commercial : Employe
    {
        private double ChiffreAffaire;
        public double _ChiffreAffaire
        {
            get
            {
                return this.ChiffreAffaire;
            }
        }
        
        public Commercial(String nom, String prenom, int age, int anneeDeRecrutement, double ChiffreAffaire) : base(nom, prenom, age, anneeDeRecrutement)
        {
            this.ChiffreAffaire = ChiffreAffaire;
        }
        public sealed override void Affiche()
        {
            base.Affiche();
            Console.WriteLine("Le chiffre d'affaire est : " + this.ChiffreAffaire);
        }
        
    }
    class Vendeur : Commercial
    {
        public Vendeur(String nom, String prenom, int age, int anneeDeRecrutement, double ChiffreAffaire):base(nom, prenom, age, anneeDeRecrutement, ChiffreAffaire)
        {
            
        }
        public override double CalculSalaire()
        {
            return this._ChiffreAffaire * (20/100) + 400;
        }
    }
    class Representant:Commercial
    {
        public Representant(String nom, String prenom, int age, int anneeDeRecrutement, double ChiffreAffaire) : base(nom, prenom, age, anneeDeRecrutement, ChiffreAffaire)
        {

        }
        public override double CalculSalaire()
        {
            return this._ChiffreAffaire * (20 / 100) + 800;
        }
    }
    class Personnel
    {
        private List<Employe> employeArray = new List<Employe>();
        public void AjouterEmploye(Employe employe)
        {
            this.employeArray.Add(employe);
        }
        public void Show()
        {
            for(int i = 0; i < employeArray.Count;i++)
            {
                Console.WriteLine("L'employe " + i + " : " + employeArray[i]);
            }
        }
        public double SalaireMoyen() {
            double totalSalaire = 0;
            for (int i = 0; i < employeArray.Count; i++)
            {
                totalSalaire += employeArray[i].CalculSalaire();
            }
            return (totalSalaire/employeArray.Count);
        }
        public void NbEmploye()
        {
            Console.WriteLine("Le nombre des employes est : " + employeArray.Count);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Representant r1 = new Representant("Harir", "Younes",21, 2016, 32);
            Representant r2 = new Representant("Arbani", "Oumaima", 20, 2016, 40);
            Representant r3 = new Representant("Azouay", "Moad", 21, 2015, 45);

            Vendeur v1 = new Vendeur("Belli", "Hanane", 21, 2017, 43.6);
            Vendeur v2 = new Vendeur("Bahamad", "Imane", 21, 2018, 90.6);

            Producteur p1 = new Producteur("Arbani", "Meryem", 24, 2009, 4);
            Producteur p2 = new Producteur("Arbani", "Younes", 17, 2011, 10);
            r1.Affiche();
            Console.WriteLine(r1.CalculSalaire());
            Console.ReadLine();
        }
    }
}
