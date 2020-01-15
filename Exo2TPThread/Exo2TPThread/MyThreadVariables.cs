using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2TPThread
{
    class MyThreadVariables
    {
        private int nominateur, denominateur;
        Object _lock = new object();

        public MyThreadVariables(int nominateur, int denominateur, object @lock)
        {
            this.nominateur = nominateur;
            this.denominateur = denominateur;
            _lock = @lock;
        }
        public void Initialiser()
        {
            lock (_lock)
            {
                Random random = new Random();
                nominateur = random.Next(1, 20);
                denominateur = random.Next(1, 20);
                Console.WriteLine("nominateur : " + nominateur + ",denominateur : " + denominateur);
            }

        }
        public void Reinitialiser()
        {
            lock (_lock)
            {
                Random random = new Random();
                nominateur = 0;
                denominateur = 0;
                Console.WriteLine("nominateur : " + nominateur+ ",denominateur : " + denominateur);

            }
        }
        public void Divise()
        {
            lock (_lock)
            {
                try
                {
                    Console.WriteLine( nominateur / denominateur);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Impossible de diviser par zero");
                }
                
            }
        }
    }
}
