using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.HTTP.Utilities
{
    public class HeaderCollection
    {
        public HeaderCollection()
        {
           headers = new Dictionary<string, Header>();
        }

        private readonly Dictionary<string, Header> headers; 

        public int Count { get { return headers.Count; } }

        public void Add(string name,string value)
        {
            Header header = new Header(name,value);
            headers.Add(name, header);
        }
    }
}
