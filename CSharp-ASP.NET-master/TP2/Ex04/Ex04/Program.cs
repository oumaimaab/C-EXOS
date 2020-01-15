using System;
namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("oussidi", "mohamed", 21);
            Personne p2 = new Personne("oussidi", "lmontadar", 22);

            if (p1.CompareTo(p2) == 0)
            {
                Console.WriteLine("they are the same");
            }
            else
            {
                Console.WriteLine("not the same");
            }
            Console.ReadLine();

        }
    }
}
