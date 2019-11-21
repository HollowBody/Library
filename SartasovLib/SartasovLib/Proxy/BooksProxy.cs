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
    public class BooksProxy
    {
        HttpClient httpClient;
        ResponseReader responseReader;
        public BooksProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44315/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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
        public async Task<Book> AddBook(Book book)
        {
            var jsonString = JsonConvert.SerializeObject(book);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/Books", content);
            var code = response.StatusCode;
            var result = responseReader.ReadObjectAsync<Book>(response);
            if (code == (HttpStatusCode)200)
            {
                return await result;
            }
            return null;
        }
        public async Task<IEnumerable<BooksInfo>> GetBooksInfo()
        {
            //var booksResponse = await httpClient.GetAsync("api/Books");
            var booksInfoResponse = await httpClient.GetStringAsync("api/Books/GetBookInfo");
            //return await responseReader.ReadArrayAsync<Book>(booksResponse);
            var booksInfo = JsonConvert.DeserializeObject<List<BooksInfo>>(booksInfoResponse);
            return booksInfo;
        }
    }
}
