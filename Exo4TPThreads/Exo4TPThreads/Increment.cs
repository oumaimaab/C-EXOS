using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4TPThreads
{
    class Increment
    {
        private int index;
        private ThreadStaticAttribute thread;
        public Increment(int index)
        {
            this.index = index;
        }
        public void Adding(int index)
        {
            //List<int> nombres = new List<int>();
            while (true)
            {
                Console.WriteLine(index);
                index++ ;

            }
        }

    }
}
