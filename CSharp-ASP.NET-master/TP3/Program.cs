using System;
using System.Threading;

namespace TP3
{
    class Program
    {
        private static int nominateur;
        private static int denominateur;
        private static Object _lock = new Object();

        static void affichage()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("salut tout le monde");
            }
        }

        static void initialiser()
        {
            Console.WriteLine("initialiser has been called");
            lock (_lock)
            {
                Random rnd = new Random();
                nominateur = rnd.Next(1, 20);
                denominateur = rnd.Next(1, 20);
            }
        }
        static void reinitialiser()
        {
            Console.WriteLine("reinitialiser has been called");
            lock (_lock)
            {
                nominateur = 0;
                denominateur =0;
            }
            
        }
        static void Divise() {
            lock (_lock)
            {
                if (denominateur == 0)
                    Console.WriteLine("you can't divise on 0");

                else
                    Console.WriteLine("Result = " + nominateur / denominateur);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(initialiser);
            Thread t2 = new Thread(Divise);
            Thread t3 = new Thread(reinitialiser);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }
    }
}

