using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteObject
{
    public class Class1:MarshalByRefObject
    {
        private int number=0;

        public int addition(int a,int b)
        {
            Console.WriteLine("Oussidi add");
            return a + b;
        }
        public int multiplication(int a, int b)
        {
            Console.WriteLine("Oussidi mult");
            return a * b;
        }
        public int incrementation(int value)
        {
            Console.WriteLine("Oussidi inc");
            number += value;
            return number;
        }

    }
}
