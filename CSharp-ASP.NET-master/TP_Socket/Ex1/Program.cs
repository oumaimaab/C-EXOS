using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sockclient;
            sockclient = new
            Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            sockclient.Connect(new
            IPEndPoint(IPAddress.Parse("127.0.0.1"), 7777));

            byte[] buf = new byte[50];
            sockclient.Receive(buf);
            String msg = ASCIIEncoding.Default.GetString(buf);
        }
    }
}
