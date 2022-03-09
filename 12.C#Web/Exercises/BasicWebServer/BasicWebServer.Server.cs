

class HttpServer
{
    public HttpServer(string IpAddress, int port)
    {
        this.ipAddress = IPAddress.Parce(ipAddress);
        this.port = port;
        this.serverListener = new TcpListener(this.ipAddress, this.port)
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

            WriteResponse(networkStream, "Hallo from the server!");
            conection.Close();
        }
    }

}
