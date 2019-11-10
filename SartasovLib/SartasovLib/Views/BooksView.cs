using LibraryApi.Models;
using SartasovLib.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SartasovLib
{
    public partial class BooksView : Form
    {
        private readonly BooksProxy _booksProxy;
        public BooksView()
        {
            InitializeComponent();
            _booksProxy = new BooksProxy();
        }

        private async void AddButtonOnClick(object sender, EventArgs e)
        {
            await GetBooks();
        }
        private async Task<IEnumerable<Book>> GetBooks()
        {
            var books = await _booksProxy.GetBooks();           
            return books;
        }

        private void DeleteButtonOnClick(object sender, EventArgs e)
        {

        }
    }
}
