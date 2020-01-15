using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO5_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> list = new List<Personne>();

            list.Add(new Personne("Elquandili", "Med", 21));
            list.Add(new Personne("Arbani", "Oumaima", 20));
            
            //list.Sort();
            var queryList = (from pointer in list orderby pointer.Nom ascending select pointer).FirstOrDefault();
            /*foreach(var value in queryList)
            {
                Console.WriteLine(value.Nom);
            }*/
            Console.WriteLine(queryList.Nom);
            Console.ReadLine();
        }
    }
}
