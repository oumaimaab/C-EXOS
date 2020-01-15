using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof (DistrebutedClass.Class1), "tcp://localhost:20/service");
            DistrebutedClass.Class1 proxy = new DistrebutedClass.Class1();
            proxy.affiche();
            Console.ReadLine();
        }
    }
}
