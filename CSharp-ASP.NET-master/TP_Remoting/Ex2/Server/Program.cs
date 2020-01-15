using RemoteObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        public Server() { }

        [Obsolete]
        public static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(5150);
            ChannelServices.RegisterChannel(channel);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Class1),"RemoteServer", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Server Activated");

            Console.ReadLine();
        }
    }
}
