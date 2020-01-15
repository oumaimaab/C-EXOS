using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Pile<double> pile = new Pile<double>();

            try
            {
                pile.Piler(23);
                pile.Piler(34);
                pile.Piler(45);
                pile.Piler(56);
            }catch(StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }

           pile.Depiler();
           
            pile.Affiche();

            Console.ReadLine();
        }
    }
}
