using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ville v1 = new Ville("Rich", "454", "5645");
            Ville v2 = new Ville("Errachidia", "454", "5645");
            Ville v3 = new Ville("Rabat", "454", "5645");
            Ville v4 = new Ville("Asfi", "454", "5645");

            EnsembleVille list = new EnsembleVille();
            list.ajouterVille(v1);
            list.ajouterVille(v2);
            list.ajouterVille(v3);
            list.ajouterVille(v4);

            list.AfficherEnsemble();
                
            Console.ReadLine();
        }
    }
}
