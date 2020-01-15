using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO4_TP2
{
    class SortByAge:IComparer<Personne>
    {
        public int Compare(Personne p1, Personne p2)
        {
            return p1.Age.CompareTo(p2.Age);
        }
    }
}
