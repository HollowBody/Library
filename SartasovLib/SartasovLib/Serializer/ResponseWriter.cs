using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SartasovLib.Serializer
{
    class ResponseWriter
    {
        private readonly JsonSerializer _serializer;

        public ResponseWriter()
        {
            _serializer = new JsonSerializer();
        }

        public StringContent WriteObject<T>(T request)
        {
            string jrequest = JsonConvert.SerializeObject(request);
            var context = new StringContent(jrequest, Encoding.UTF8, "application/json");
            return context;
        }
    }
}