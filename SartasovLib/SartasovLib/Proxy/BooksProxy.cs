using LibraryApi.Models;
using Newtonsoft.Json;
using SartasovLib.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SartasovLib.Proxy
{
    public class BooksProxy
    {
        HttpClient httpClient;
        JsonSerializer serializer;
        ResponseWriter responseWriter;
        ResponseReader responseReader;
        public BooksProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44315/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            serializer = new JsonSerializer();
            responseWriter = new ResponseWriter();
            responseReader = new ResponseReader();
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var booksResponse = await httpClient.GetStringAsync("api/Books");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var books = JsonConvert.DeserializeObject<List<Book>>(booksResponse);
            return books;
        }
    }
}
