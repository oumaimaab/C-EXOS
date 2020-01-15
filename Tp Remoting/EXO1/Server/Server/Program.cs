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
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(20);
            ChannelServices.RegisterChannel(channel,false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(DistrebutedClass.Class1),"service",WellKnownObjectMode.Singleton);
            Console.ReadLine();

        }
    }
}
