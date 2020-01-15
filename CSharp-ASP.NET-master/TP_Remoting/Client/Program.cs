using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using nameSpaceRemote;
namespace Client
{
    public class Client
    {
        ///constructor
        public Client()
        {
        }

        ///main method
        [Obsolete]
        public static int Main(string[] args)
        {
            RemotingConfiguration.Configure(@"..\..\App.config", false);
            
            RemoteObject remObject = new RemoteObject();

            remObject.Affichage();

            Console.ReadLine();
            return 0;
        }
    }
}
