using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO6_TP2
{
    class EnsembleVille
    {
        private Dictionary<string,Ville> lesVilles;
        
        public Ville getVille(string nomVille)
        {
            return lesVilles[nomVille];
        }

        public void ajouterVille(Ville uneVille)
        {
            if (lesVilles.ContainsKey(uneVille.NomVille))
            {
                Console.WriteLine("Cette ville existe déjà");
            }
            lesVilles.Add(uneVille.NomVille, uneVille);
        }
        public String getCodePostal(String nomVille)
        {
            if (!lesVilles.ContainsKey(nomVille))
            {
                Console.WriteLine("Cette n'existe ville pas");
            }
            return lesVilles[nomVille].CodeCommune;
        }
        public void AfficheEnsemble()
        {
            List<string> nomVillesSorted = new List<string>();
            foreach(var ville in lesVilles)
            {
                nomVillesSorted.Add(ville.Key);
            }
            nomVillesSorted.Sort();
            foreach(string ville in nomVillesSorted)
            {
                Console.WriteLine(ville);
            }
        }

    }
}
