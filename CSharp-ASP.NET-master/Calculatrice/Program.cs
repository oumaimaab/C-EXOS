using System;

namespace Calculatrice
{
    class Program
    {
        public static int soustraction(int a, int b) { return a - b; }
        public static int addition(int a, int b) { return a + b; }
        public static int multiplication(int a, int b) { return a * b; }
        public static int division(int a, int b) { return b==0 ? 0: a / b; }

        public delegate int Operation(int x, int y);

        public static void calculatrice(int x,int y,Operation p)
        {
            Console.WriteLine(p(x, y));
        }
        
        static void Main(string[] args)
        {
            calculatrice(34, 7, addition);
            calculatrice(34, 7, (x,y)=>x*y*10);

            Console.ReadLine();
        }
    }
}
