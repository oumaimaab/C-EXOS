using System;
using System.Collections.Generic;

namespace Ex7
{
    class Pile<T>
    {
        private Stack<T> tab;
        private Queue<T> tab2;

        public Pile()
        {
            tab = new Stack<T>(100);
        }
        public void Piler(T element)
        {
            if (tab.Count >= 100) 
                throw new StackOverflowException("the array is full you can't add on it");
            else
                tab.Push(element);
        }
        public void Depiler()
        {
            if (tab.Count == 0)
                throw new InvalidOperationException("You can't delete elt because array is empty");
            else
            {
                tab.Pop();
            }
            
        }
        public void Affiche()
        {
            foreach(T elt in tab)
            {
                Console.WriteLine(elt);
            }
        }
    }
}
