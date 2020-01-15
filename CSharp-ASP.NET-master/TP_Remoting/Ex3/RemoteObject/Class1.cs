using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteObject
{
    public class Class1:MarshalByRefObject
    {
        private int i;
        private int nbTentative=0;
        public Class1() {
            Random rand = new Random();
            i = rand.Next(1, 10);
            Console.WriteLine("Random Number" + i);
        }
        public string jouer(int x) {
            String str;

            if (nbTentative <= 4)
            {
                if (x > i)
                {
                    str = "plus grand";
                }
                else
                {
                    if (x == i)
                    {
                        str = "Gagné";
                    }
                    else
                    {
                        str = "plus petit";
                    }
                }
            }
            else
            {
                str = "Nombre des essais dépassé";
            }

            nbTentative++;

            Console.WriteLine("Jouer() called and nb="+nbTentative);

            return str;
        }
        public int getNombreTentatives()
        {
            return nbTentative;
        }
        public int score()
        {
            return 10 - nbTentative;
        }
    }
}
