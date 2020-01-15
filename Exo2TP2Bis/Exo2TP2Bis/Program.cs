using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EXO1_TP2
{
    class Employe
    {
        private string nom, prenom;
        private int age, anneeDeRecrutement;
        public Employe(string nom, string prenom, int age, int anneeDeRecrutement)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.anneeDeRecrutement = anneeDeRecrutement;
        }
        public virtual string Affiche()
        {
            return "Le nom est : " + this.nom+"Le prenom est : " + this.prenom +" L'age est : " + this.age +" L'annee de recrutement est : " + this.anneeDeRecrutement;
        }
        public virtual double CalculSalaire()
        {
            return 0;
        }
    }
    class Producteur : Employe
    {
        private int nbUnite;
        public Producteur(string nom, string prenom, int age, int anneeDeRecrutement, int nbUnite) : base(nom, prenom, age, anneeDeRecrutement)
        {
            this.nbUnite = nbUnite;
        }
        public override double CalculSalaire()
        {
            return this.nbUnite * 5;
        }
        public override string Affiche()
        {
            
            return base.Affiche() + " Le salaire du prodecteur est : " + this.CalculSalaire();
        }
    }
    class Commercial : Employe
    {
        private double ChiffreAffaire;
        public double _ChiffreAffaire
        {
            get
            {
                return ChiffreAffaire;
            }
        }

        public Commercial(string nom, string prenom, int age, int anneeDeRecrutement, double ChiffreAffaire) : base(nom, prenom, age, anneeDeRecrutement)
        {
            this.ChiffreAffaire = ChiffreAffaire;
        }
        public sealed override string Affiche()
        {
            
            return base.Affiche()+"Le chiffre d'affaire est : " + this.ChiffreAffaire;
        }

    }
    class Vendeur : Commercial
    {
        public Vendeur(string nom, string prenom, int age, int anneeDeRecrutement, double ChiffreAffaire) : base(nom, prenom, age, anneeDeRecrutement, ChiffreAffaire)
        {

        }
        public override double CalculSalaire()
        {
            return this._ChiffreAffaire * (20 / 100) + 400;
        }
    }
    class Representant : Commercial
    {
        public Representant(string nom, string prenom, int age, int anneeDeRecrutement, double ChiffreAffaire) : base(nom, prenom, age, anneeDeRecrutement, ChiffreAffaire)
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
            employeArray.Add(employe);
        }
        public string Show()
        {
            string result = "";
            for (int i = 0; i < employeArray.Count; i++)
            {
                result= "L'employe " + (i+1) + " : " + employeArray[i].Affiche();
                return result;
            }
            return result;
        }
        public double SalaireMoyen()
        {
            double totalSalaire = 0;
            for (int i = 0; i < employeArray.Count; i++)
            {
                totalSalaire += employeArray[i].CalculSalaire();
            }
            return (totalSalaire / employeArray.Count);
        }
        public string NbEmploye()
        {
            return "Le nombre des employes est : " + employeArray.Count;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Exo2TP2Bis.Form1());
        }
    }
}
