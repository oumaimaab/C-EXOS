using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5
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

            var listLinq = from p in list
                    select p;

            foreach (var p in listLinq)
            { Console.WriteLine(p.Nom); }

            Console.ReadLine();
        }
    }
}
