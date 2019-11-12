using LibraryApi.Models;
using Newtonsoft.Json;
using SartasovLib.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace SartasovLib.Proxy
{
    class PenaltiesProxy
    {
        HttpClient httpClient;
        ResponseReader responseReader;
        public PenaltiesProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44315/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            responseReader = new ResponseReader();
        }
        public async Task<IEnumerable<Penalty>> GetPenalties()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var penaltiesResponse = await httpClient.GetStringAsync("api/Penalties");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var penalties = JsonConvert.DeserializeObject<List<Penalty>>(penaltiesResponse);
            return penalties;
        }
        public async Task<Penalty> AddPenalty(Penalty penalty)
        {
            var jsonString = JsonConvert.SerializeObject(penalty);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/Penalties", content);
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<Penalty>(response);
            if (code == (HttpStatusCode)200)
            {
                return await result;
            }
            return null;
        }
    }
}
