using System;
using System.Collections;
using System.Collections.Generic;

namespace Ex4_1
{
    class PersonneCompare: IComparer<Personne>
    {
        public int Compare(Personne x, Personne y)
        {
            return x.Nom.CompareTo(y.Nom);
        }
    }
}
