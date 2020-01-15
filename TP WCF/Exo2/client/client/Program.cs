using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client personne = new ServiceReference1.Service1Client();
            ServiceReference1.Personne p = new ServiceReference1.Personne();
            p = personne.createPersonne("oum", "arbani", 20);
            Console.WriteLine(personne.DescriptionPersonne(p));
            
            Console.ReadLine();
        }
    }
}
