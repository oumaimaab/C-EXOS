
using System.Collections.Generic;

namespace Ex4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> list = new List<Personne>();
            list.Add(new Personne("oussidi", "med", 21));
            list.Add(new Personne("Elasri", "hicham", 25));
            list.Add(new Personne("Gharib", "yassin", 22));

            list.Sort(new PersonneCompare());

            foreach (Personne p in list)
            {
                System.Console.WriteLine(p.Nom);
            }


            System.Console.ReadLine();
        }
    }
}
