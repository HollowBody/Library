using LibraryApi.Models;
using SartasovLib.Proxy;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Web;
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
        private async void BooksViewOnLoad(object sender, EventArgs e)
        {
            await LoadData();
            InitializeView();
        }
        private async Task LoadData()
        {
            BindingSource booksBindingSource = new BindingSource
            {
                DataSource = await GetBooks()
            };
            BooksGrid.DataSource = booksBindingSource;
        }
        private async Task<IEnumerable<Book>> GetBooks()
        {
            var books = await _booksProxy.GetBooks();
            return books;
        }
        private void InitializeView()
        {
            BooksGrid.Columns[0].HeaderText = @"№";
            BooksGrid.Columns[1].HeaderText = @"Название";
            BooksGrid.Columns[2].HeaderText = @"Автор";
            BooksGrid.Columns[3].HeaderText = @"Год выпуска";
            BooksGrid.Columns[4].HeaderText = @"Цена";
            BooksGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async void AddButtonOnClick(object sender, EventArgs e)
        {
            await PostBook();
            await LoadData();
            InitializeView();
        }

        private async Task PostBook()
        {
            if (!string.IsNullOrWhiteSpace(AuthorField.Text) && !string.IsNullOrWhiteSpace(CostField.Text) && !string.IsNullOrWhiteSpace(IssueDateField.Text) && !string.IsNullOrWhiteSpace(NameField.Text))
            {
                Book book = new Book
                {
                    Author = AuthorField.Text,
                    Cost = Convert.ToDouble(CostField.Text, NumberFormatInfo.InvariantInfo),
                    IssueDate = IssueDateField.Value,
                    Name = NameField.Text
                };
                try
                {
                    await _booksProxy.AddBook(book);
                }
                catch (HttpException ex)
                {
                    MessageBox.Show($"Ошибка:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Укажите данные о книге в верном формате", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteButtonOnClick(object sender, EventArgs e)
        {

        }

        private void BooksViewOnFormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }
    }

}

