using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO7_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pile<int> pile = new Pile<int>();
            pile.Piler(1);
            pile.Piler(2);
            
            pile.Piler(3);
            
            pile.Piler(4);
            pile.Depiler();
            pile.Affiche();

        }
    }
}
