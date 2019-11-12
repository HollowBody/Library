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
    
    class AccountsProxy
    {
        HttpClient httpClient;
        ResponseReader responseReader;
        public AccountsProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44315/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            responseReader = new ResponseReader();
        }
        public async Task<IEnumerable<LibraryAccount>> GetLibraryAccounts()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var libraryAccountsResponse = await httpClient.GetStringAsync("api/LibraryAccounts");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var libraryAccounts = JsonConvert.DeserializeObject<List<LibraryAccount>>(libraryAccountsResponse);
            return libraryAccounts;
        }
        public async Task<LibraryAccount> AddLibraryAccount(LibraryAccount libraryAccount)
        {
            var jsonString = JsonConvert.SerializeObject(libraryAccount);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/LibraryAccount", content);
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<LibraryAccount>(response);
            if (code == (HttpStatusCode)200)
            {
                return await result;
            }
            return null;
        }
    }
}
