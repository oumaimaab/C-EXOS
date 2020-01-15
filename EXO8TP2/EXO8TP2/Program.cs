using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO8TP2
{
    class Program
    {
        public delegate int calcul(int x, int y);
        static void Main(string[] args)
        {
            calcul myDelegate = null;
            Calculatrice(1, 2, Addition);
            Calculatrice(1, 2, Soustraction);
            Calculatrice(1, 2, Multiplication);
            Calculatrice(1, 2, Division);
       
            myDelegate += (x, y) =>x * y * 10;
            myDelegate = new calcul(Soustraction);
            myDelegate.Invoke(2, 1);
            //Console.WriteLine("Le résultat est :"+myDelegate(1, 2));
            Console.ReadKey();

        }
        static int Soustraction(int x,int y)
        {
            return (x - y);
        }
        static int Addition(int x, int y)
        {
            return (x + y);
        }
        static int Multiplication(int x, int y)
        {
            return (x * y);
        }
        static int Division(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Impossible de diviser par zero");
            }
            return x / y;
        }
        static void Calculatrice(int x, int y,calcul methode)
        {
            int result;
            result = methode(x, y);
            Console.WriteLine("Le résultat est : " + result);
        }
    }
}
