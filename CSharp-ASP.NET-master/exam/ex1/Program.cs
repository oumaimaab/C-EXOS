using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassGen<int> t = new ClassGen<int>();
            t.add(10);
            t.add(10);
            t.add(10);
            t.add(10);
            t.add(10);

            int c = t.renvoyer(1);

            Console.WriteLine(c);

            Console.ReadLine();
        }
    }

    class ClassGen<T>
    {
        private T[] tab;
        private int nb_element;
        private const int MAX = 10;

        public ClassGen(){
            tab = new T[MAX];
        }

        public void add(T elm)
        {
            // nb-element=
           if (nb_element > MAX)
            {
                tab[nb_element - 1] = elm;
            }
            else
            {
                Console.WriteLine("La table est plein");
            }
        }
        public T renvoyer(int index)
        {
            return tab[index];
        }

    }
}
