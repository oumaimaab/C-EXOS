using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exo2TPThread
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Object _lock = new object();
            MyThreadVariables myThread = new MyThreadVariables(1, 1, _lock);
            Thread thread1 = new Thread(myThread.Initialiser);
            Thread thread2 = new Thread(myThread.Reinitialiser);
            Thread thread3 = new Thread(myThread.Divise);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadLine();

        }

        
    }
}
