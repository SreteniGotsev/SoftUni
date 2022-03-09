using BasicWebServer.HTTP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.HTTP
{
    public class HTTPRequest
    {
        public Method Method { get; private set; }
        public string Url { get; private set; }

        public HeaderCollection Headers { get; private set; }

        public string Body { get; private set; }

        public static HTTPRequest Parse(string request)
        {
            var lines = request.Split("\r\n");
            var startLine = lines[0].Split(" ");
            var method = ParseMethod(startLine[0]);
            var url = startLine[1];
            var headers = ParseHeaders(lines.Skip(1));
            var bodylines = lines.Skip(headers.Count+2).ToArray();
            var body =string.Join("\r\n", bodylines);

            return new HTTPRequest
            {
                Method = method,
                Url = url,
                Headers = headers,
                Body = body
            };
        }

        private static HeaderCollection ParseHeaders(IEnumerable<string> enumerable)
        {
           var headers = new HeaderCollection();

            foreach (var line in enumerable)
            {
                if(line == String.Empty)
                {
                    break;
                }

                var headerParts = line.Split(':',2);

                if (headerParts.Length != 2)
                {
                    throw new InvalidOperationException("Request is not valid");
                }

                var headerName = headerParts[0];
                var headerValue = headerParts[1].Trim();

                headers.Add(headerName, headerValue);

            }

            return headers;
        }

        private static Method ParseMethod(string method)
        {
            try
            {
                return(Method)Enum.Parse(typeof(Method), method, true);
            }
            catch (Exception)
            {

                throw new InvalidOperationException($"Method,'{method}' is not supported");
            }
        }
    }
}
