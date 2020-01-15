using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO3_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> list = new List<Personne>();

            list.Add(new Personne("Liari", "Samia", 20));
            list.Add(new Personne("Arbani", "Oumaima", 20));
            
            list.Sort();
            foreach(Personne v in list)
            {
                Console.WriteLine(v.Nom);
       
            }
            Console.ReadLine();

        }
    }
}
