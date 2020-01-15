using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3_TP1
{
    public enum Ville
    {
        Safi,
        Marrakech,
        Rabat,
        Casa
    }
    class Personne
	{
        
        private Ville _ville;
        private readonly string nom;
		private string prenom, tel;
		public int age;
		public Personne() {
			Console.WriteLine("Construction de classe personne");
		}
		public Personne(string nom, string prenom, int age, string tel,Ville _ville) :this()
		{
            Console.WriteLine("Démarrage du programme");
			this.nom = nom;
			this.prenom = prenom;
			this.age = age;
			this.tel = tel;
            this._ville = _ville;
		}
		public int Age {
			get {
				return age;
			}
            set {
                age = value;    
            }
		}
		public Personne(Personne p)
		{
			nom = p.nom;
			prenom = p.prenom;
			age = p.age;
			tel = p.tel;
		}
		static void changePersonne(ref int ancien_age) {
			string newAge;
			int ageNv;
            Console.WriteLine("Enter the age :  ");
            newAge = Console.ReadLine();
			ageNv = Convert.ToInt32(newAge);
			ancien_age = ageNv;
            Console.WriteLine("The new age is: "+ancien_age);
		}
		public void display()
		{
			Console.WriteLine(this.age);
		}
		public void SavoirOrigine()
        {
            switch (_ville)
            {
                case Ville.Safi:
                    {
                        Console.WriteLine("Originaire de Safi");
                        break;
                    }
                case Ville.Rabat:
                    {
                        Console.WriteLine("Originaire de Rabat");
                        break;
                    }
                case Ville.Marrakech:
                    {
                        Console.WriteLine("Originaire de Marrakech");
                        break;
                    }
                case Ville.Casa:
                    {
                        Console.WriteLine("Originaire de Casa");
                        break;
                    }
                default:break;

            }
        }
		static void Main(string[] args)
		{
			Personne p = new Personne("Oumaima", "Arbani", 20, "0688639282",Ville.Casa);
            Personne.changePersonne(ref p.age);
            p.SavoirOrigine();
            Console.ReadLine();
        }

		
	}
}
