using System;

namespace ConsoleApp2
{
    class GuichetsBanque
    {
        private bool[] tabGuichets;
        private int N=0;
        GuichetsBanque(int N)
        {
            this.N = N;
            tabGuichets = new bool[N];
            for (int i = 0; i < N; i++)
            {
                tabGuichets[i] = true;
            }
        }

        public int guichetLibre()
        {
            int pos=-1;
            for(int i = 0; i < N; i++)
            {
                if(tabGuichets [i]== true)
                {
                    pos= i;
                    break;
                }
                     
            }

            return pos;
            
            
        }

        public int nbGuichetLibre()
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (tabGuichets[i] == true)
                {
                   sum++;
                }

            }

            return sum;

        }
        static void Main(string[] args)
        {

            GuichetsBanque test = new GuichetsBanque(10);
            Console.WriteLine(test.guichetLibre());
            Console.WriteLine("le nb guichet libre est : "+test.nbGuichetLibre());
            Console.ReadLine();
        }
    }
}
