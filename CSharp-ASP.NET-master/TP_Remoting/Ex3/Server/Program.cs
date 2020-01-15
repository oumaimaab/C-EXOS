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
        [Obsolete]
        public static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(5150);
            ChannelServices.RegisterChannel(channel);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Class1), "RemoteServer", WellKnownObjectMode.Singleton);

            Console.WriteLine("Server Activated");

            Console.ReadLine();
        }
    }
}
