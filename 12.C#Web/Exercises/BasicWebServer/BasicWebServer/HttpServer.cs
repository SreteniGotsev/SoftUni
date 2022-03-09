using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer
{


    public class HttpServer
    {
        public HttpServer(string IpAddress, int port)
        {
            this.ipAddress = IPAddress.Parse(IpAddress);
            this.port = port;
            this.serverListener = new TcpListener(this.ipAddress, this.port);
        }
        private readonly IPAddress ipAddress;
        private readonly int port;
        private readonly TcpListener serverListener;

        public void Start()
        {
            serverListener.Start();
            System.Console.WriteLine($"Server listening on port {this.port}");
            System.Console.WriteLine("Listening for requests...");

            while (true)
            {
                var connection = serverListener.AcceptTcpClient();
                var networkStream = connection.GetStream();

                var requestText = this.ReadRequest(networkStream);
                Console.WriteLine(requestText);
                connection.Close();
            }
        }

        //        private void WriteResponse(NetworkStream networkStream, string message)
        //        {
        //            int contentLength = Encoding.UTF8.GetByteCount(message);
        //            string response = $@"HTTP/1.1 200 OK
        //Content-Type: text/pain; charset=UTF8;
        //Content-Length: {contentLength}
        //{message}";
        //            var responesBytes = Encoding.UTF8.GetBytes(response);
        //            networkStream.Write(responesBytes);

        //        }

        private string ReadRequest(NetworkStream networkStream)
        {
            var buffer = new byte[1024];
            var sb = new StringBuilder();
            var totalBytes = 0;

            do
            {
                var bytesRead = networkStream.Read(buffer, 0, 1024);
                
                totalBytes += bytesRead;
                
                if (totalBytes > 10 * 1024)
                {
                    throw new InvalidOperationException("Request is too large");
                }

                sb.Append(Encoding.UTF8.GetString(buffer, 0, 1024));
            } while (networkStream.DataAvailable);

            return sb.ToString();

        }

    }

}
