using System;
using System.Collections;
using System.Collections.Generic;

namespace Ex5
{
    class PersonneCompare: IComparer<Personne>
    {
        public int Compare(Personne x, Personne y)
        {
            return x.Nom.CompareTo(y.Nom);
        }
    }
}
