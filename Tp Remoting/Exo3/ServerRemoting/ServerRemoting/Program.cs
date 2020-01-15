using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ServerRemoting
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(100);
            ChannelServices.RegisterChannel(channel,false);
            RemotingConfiguration.RegisterActivatedServiceType(typeof (NombreCache.ClassLibrary1));
            Console.ReadLine();
        }
    }
}
