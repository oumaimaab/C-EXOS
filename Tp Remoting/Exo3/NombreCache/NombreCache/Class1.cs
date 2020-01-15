using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCache
{
    public class ClassLibrary1
    {
        private int i = 0;
        private int nbTentative =0;
        private bool s = false;
        public ClassLibrary1()
        {
            Random random = new Random();
            //this.i =random.Next(1, 10);
            i = 5;
            Console.WriteLine(i);
        }
        public string joueur(int x)
        {
            if (getNombreTentatives()<= 4)
            {
                if (x.Equals(i))
                {
                    s = true;
                    return "Gagné";
                }
                else if (x < i)
                {
                    this.nbTentative++;
                    return "plus petit";
                }
                else if (x > i)
                {
                    this.nbTentative++;
                    return "plus grand";
                }
            }
    

            return "Nombre des essais dépassé";
        }
        public int getNombreTentatives()
        {
            return this.nbTentative;
        }
        public int score()
        {
            if (s)
            {
                return 10 - getNombreTentatives();
            }
            return 0;
        }
    }
}
