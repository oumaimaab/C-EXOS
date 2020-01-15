using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    public class ClassLibrary
    {
        private int n = 0;
        public int addition(int a, int b)
        {
            return a + b;
        }
        public int multiplication(int a, int b)
        {
            return a*b;
        }
        public int incrementation(int value)
        {
            n += value;
            return n;
        }
    }
}
