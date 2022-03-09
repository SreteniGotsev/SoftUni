using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BasicWebServer
{
    class Program
    {
        static void Main()
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used

            string ipAddress = "127.0.0.1";
            int port = 8081;

            HttpServer server = new HttpServer(ipAddress, port);

            server.Start();
            



        }
    }
}