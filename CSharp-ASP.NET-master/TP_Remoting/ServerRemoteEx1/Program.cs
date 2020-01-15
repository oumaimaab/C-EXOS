using nameSpaceRemote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ServerRemoteEx1
{
    public class Server
    {
        public Server() { }

        [Obsolete]
        public static int Main(string[] args)
        {
            RemotingConfiguration.Configure(@"..\..\App.config", false);

            Console.WriteLine("Server Activated");
            return 0;
        }
    }
}
