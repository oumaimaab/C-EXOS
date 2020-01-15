using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock;
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            sock.Bind(new IPEndPoint(IPAddress.Parse("192.168.43.72"), 7777));
            sock.Listen(1);
            Socket sockServeur = sock.Accept();

            String message ="Hello From wow";
            byte[] buf = ASCIIEncoding.Default.GetBytes(message);
            sockServeur.Send(buf);
        }
    }
}
