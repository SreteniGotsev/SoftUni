using BasicWebServer.HTTP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.HTTP
{
    public class HTTPResponse
    {
        public HTTPResponse(StatusCode status)
        {
            this.Status = status;
            Headers = new HeaderCollection();

            Headers.Add("Server", "My web server");
            Headers.Add("Date", $"{DateTime.UtcNow:r}");
        }

        public StatusCode Status { get; set; }
        public HeaderCollection Headers { get; set; }
        public string Body { get; set; } 

    }
}
