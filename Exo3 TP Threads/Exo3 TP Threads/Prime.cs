using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3_TP_Threads
{
    class Prime
    {
        private int number;

        public Prime(int number)
        {
            this.number = number;
        }
        public List<int> isPrime(int number)
        {
            List<int> primes = new List<int>();
            primes.Add(1);
            for (int i = 0; i < number; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    primes.Add(i);
                }
            }
            return primes;     
        }
        
    }
}
