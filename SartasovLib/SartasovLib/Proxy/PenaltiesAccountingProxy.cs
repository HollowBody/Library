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
    public class PenaltiesAccountingProxy
    {
        HttpClient httpClient;
        ResponseReader responseReader;

        public PenaltiesAccountingProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44315/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            responseReader = new ResponseReader();
        }
        public async Task<IEnumerable<PenaltiesAccounting>> GetPenaltiesAccounting()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var penaltiesAccountingResponse = await httpClient.GetStringAsync("api/PenaltiesAccountings");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var penaltiesAccounting = JsonConvert.DeserializeObject<List<PenaltiesAccounting>>(penaltiesAccountingResponse);
            return penaltiesAccounting;
        }
        public async Task<PenaltiesAccounting> AddPenaltiesAccounting(PenaltiesAccounting penaltiesAccounting)
        {
            var jsonString = JsonConvert.SerializeObject(penaltiesAccounting);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/PenaltiesAccountings", content);
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<PenaltiesAccounting>(response);
            if (code == (HttpStatusCode)200)
            {
                return await result;
            }
            return null;
        }
        public async Task<IEnumerable<AccountInfo>> GetAccountsInfo()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var accountsInfoResponse = await httpClient.GetStringAsync("api/PenaltiesAccountings/GetAccountsInfo");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var penaltiesAccounting = JsonConvert.DeserializeObject<List<AccountInfo>>(accountsInfoResponse);
            return penaltiesAccounting;
        }
        public async Task<IEnumerable<PenaltiesAccountingsInfo>> GetPenaltiesAccountingsInfo()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var penaltiesAccountingInfoResponse = await httpClient.GetStringAsync("api/PenaltiesAccountings/GetPenaltiesAccountingsInfo");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var penaltiesAccounting = JsonConvert.DeserializeObject<List<PenaltiesAccountingsInfo>>(penaltiesAccountingInfoResponse);
            return penaltiesAccounting;
        }
    }
}
