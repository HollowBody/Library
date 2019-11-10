using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SartasovLib.Serializer
{
    class ResponseReader
    {
        public ResponseReader()
        {
            _serializer = new JsonSerializer();
        }


        private readonly JsonSerializer _serializer;


        public async Task<T> ReadObjectAsync<T>(HttpResponseMessage response)
        {
            return await DeserializeContent<T>(response);
        }

        public T ReadObject<T>(HttpResponseMessage response)
        {
            return ReadObjectAsync<T>(response).GetAwaiter().GetResult();
        }


        public async Task<IEnumerable<T>> ReadArrayAsync<T>(HttpResponseMessage response) 
        { 
            return await DeserializeContent<List<T>>(response);
        }


        public async Task<T> ReadVariableAsync<T>(HttpResponseMessage response)
        {
            return await DeserializeContent<T>(response);
        }

        public IEnumerable<T> ReadArray<T>(HttpResponseMessage response)
        {
            return ReadArrayAsync<T>(response).GetAwaiter().GetResult();
        }


        private async Task<T> DeserializeContent<T>(HttpResponseMessage response)
        {
            using (var reader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
                using (var jReader = new JsonTextReader(reader))
                {
                    return _serializer.Deserialize<T>(jReader);
                }
            }
        }
    }
}
