using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(20);
            ChannelServices.RegisterChannel(channel,false);
            //Singlton mode
            // RemotingConfiguration.RegisterWellKnownServiceType(typeof(Exo2.ClassLibrary), "service ", WellKnownObjectMode.Singleton);
            /*CAO MODE*/

            RemotingConfiguration.RegisterActivatedServiceType(typeof (Exo2.ClassLibrary));
            Console.ReadLine();
        }
    }
}
