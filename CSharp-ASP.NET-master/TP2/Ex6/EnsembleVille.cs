using System;
using System.Collections.Generic;

namespace Ex6
{
    class EnsembleVille
    {
        private Dictionary<String, Ville> lesVilles;

        public EnsembleVille()
        {
            lesVilles = new Dictionary<string, Ville>();
        }

        public void ajouterVille(Ville uneVille)
        {
            int drop = 0;
            foreach(Ville v in lesVilles.Values)
            {
                if (v.Equals(uneVille))
                {
                    drop = 1;
                    break;
                }
            }

            if (drop == 1)
                Console.WriteLine("cette ville deja existe");
            else
                lesVilles.Add(uneVille.NomVille, uneVille);
            
        }
        public void AfficherEnsemble(){
            foreach (Ville v in lesVilles.Values)
            {
                Console.WriteLine(v);
            }
        }

        public Ville GetVille(String ville)
        {
            Ville temp ;
            foreach (String v in lesVilles.Keys)
            {
                if (ville.Equals(v))
                {
                    temp= lesVilles[v];
                    break;
                }
            }

            return temp.NomVille.Equals("") ? null : temp;

        }
     
    }
}
