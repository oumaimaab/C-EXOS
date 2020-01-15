using System;

namespace ConsoleApp1
{

    class Equation
    {
        private double a;
        private double b;
        private double c;
        private double delta;
        private double r1;
        private double r2;

        public Equation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void calculRacines()
        {
            delta = b * b - (4 * a * c);
            r1 = ((b * -1) - Math.Sqrt(delta)) / 2 * a;
            r2 = ((b * -1) + Math.Sqrt(delta)) / 2 * a;
        }

        public override String ToString()
        {
            if (delta > 0) {
                return "r1=" + r1 + " et r2=" + r2;
            } else {
                return "pas de racine réelle";
            }
        }

        public double  A{
            get
            {
                return a;
            }

            set
            {
                if (value == 0)
                    Console.WriteLine("le programme ne traite pas le cas où a = 0");
                else
                    a = value;
            }
                 
         }

        public double B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }

        }

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }

        }


    }

    class Probleme
    {
        static void Main(string[] args)
        {
            Equation e1 = new Equation(2.2, 9.1, 0.3);
            e1.calculRacines();
            e1.A = 0;
            Console.WriteLine(e1);
        }
    }

}
