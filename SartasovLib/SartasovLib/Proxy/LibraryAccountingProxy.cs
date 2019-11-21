using LibraryApi.Models;
using Newtonsoft.Json;
using SartasovLib.Models;
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
    class LibraryAccountingProxy
    {
        HttpClient httpClient;
        ResponseReader responseReader;
        public LibraryAccountingProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44315/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            responseReader = new ResponseReader();
        }
        public async Task<IEnumerable<LibraryAccounting>> GetLibraryAccountings()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var libraryAccountingsResponse = await httpClient.GetStringAsync("api/LibraryAccountings");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var libraryAccountings = JsonConvert.DeserializeObject<List<LibraryAccounting>>(libraryAccountingsResponse);
            return libraryAccountings;
        }
        public async Task<LibraryAccounting> AddLibraryAccounting(LibraryAccounting libraryAccounting)
        {
            var jsonString = JsonConvert.SerializeObject(libraryAccounting);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/LibraryAccountings", content);
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<LibraryAccounting>(response);
            if (code == (HttpStatusCode)200)
            {
                return await result;
            }
            return null;
        }
        public async Task<IEnumerable<LibraryAccountingInfo>> GetLibraryAccountingsInfo()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var libraryAccountingInfoResponse = await httpClient.GetStringAsync("api/LibraryAccountings/GetLibraryAccountingInfo");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var penaltiesAccounting = JsonConvert.DeserializeObject<List<LibraryAccountingInfo>>(libraryAccountingInfoResponse);
            return penaltiesAccounting;
        }
    }
}
