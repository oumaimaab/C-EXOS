using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO4_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> list = new List<Personne>();
            list.Add(new Personne("Arbani", "Oumaima", 20));
            list.Add(new Personne("Elquandili", "Med", 21));

            string input = Console.ReadLine();
            if (input == "1")
            {
                list.Sort(new ComparePersonne());
            }
            else if(input == "2")
            {
                list.Sort(new SortByAge());
            }
            else if (input == "3")
            {
                list.Sort(new SortByFirstName());
            }


            Console.WriteLine(list.BinarySearch(new Personne("Liari", "Samia", 20), new ComparePersonne()));
            Console.ReadLine();

        }
    }
}
