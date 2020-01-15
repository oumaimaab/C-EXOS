using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO7_TP2
{
    class Pile<T>
    {
        private T[] tab = new T[100];
        private int pointer;

        public Pile()
        {
            this.pointer = 0;
        }

        public T Depiler()
        {
            List<T> newList = new List<T>(tab);
            T result = newList[pointer];
            try
            {
                newList.RemoveAt(pointer);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.GetType());
                throw;
            }
            this.pointer -= 1;
            return result;

        }
        public void Piler(T value)
        {
            try
            {
                tab[pointer] = value;
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.GetType());
                throw;
            }
            this.pointer += 1;


        }
        public void Affiche()
        {
            for(int i=0;i<pointer;i++)
            {
                Console.Write(tab[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
