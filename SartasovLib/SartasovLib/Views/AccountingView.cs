using LibraryApi.Models;
using SartasovLib.Models;
using SartasovLib.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SartasovLib.Views
{
    public partial class AccountingView : Form
    {
        private LibraryAccountingProxy _libraryAccountingProxy;
        private AccountsProxy _accountsProxy;
        private BooksProxy _booksProxy;
        public AccountingView()
        {
            InitializeComponent();
            _libraryAccountingProxy = new LibraryAccountingProxy();
            _accountsProxy = new AccountsProxy();
            _booksProxy = new BooksProxy();
        }
        private async void AccountingViewOnLoad(object sender, EventArgs e)
        {
            try
            {
                await AccountsLoad();
                await LoadData();
                await BooksLoad();
                InitializeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadData()
        {
            BindingSource penaltyAccountingBindingSource = new BindingSource
            {
                DataSource = await GetLibraryAccountingInfo()
            };
            AccountingGrid.DataSource = penaltyAccountingBindingSource;
        }
        private async Task<IEnumerable<LibraryAccountingInfo>> GetLibraryAccountingInfo()
        {
            var libraryAccountingInfo = await _libraryAccountingProxy.GetLibraryAccountingsInfo();
            return libraryAccountingInfo;
        }
        private void InitializeView()
        {
            AccountingGrid.Columns[0].HeaderText = @"№";
            AccountingGrid.Columns[1].HeaderText = @"Тип";
            AccountingGrid.Columns[2].HeaderText = @"Книга";
            AccountingGrid.Columns[3].HeaderText = @"Абонемент";
            AccountingGrid.Columns[4].HeaderText = @"Дата оформления";
            AccountingGrid.Columns[5].HeaderText = @"Дата сдачи";
            AccountingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async Task AccountsLoad()
        {
            var accounts = await _accountsProxy.GetAccountsInfo();
            //_accountsBindingSource.DataSource = accounts;
            AccountsDrop.DataSource = accounts;
            AccountsDrop.DisplayMember = "AccountData";
            AccountsDrop.ValueMember = "AccountID";

        }
        private async Task BooksLoad()
        {
            var books = await _booksProxy.GetBooksInfo();
            //_accountsBindingSource.DataSource = accounts;
            BookDrop.DataSource = books;
            BookDrop.DisplayMember = "BookData";
            BookDrop.ValueMember = "BookID";
        }
        private async void AddButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                await PostPenalty();
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task PostPenalty()
        {
            if (!string.IsNullOrWhiteSpace(AccountsDrop.Text) && !string.IsNullOrWhiteSpace(TypeField.Text) && !string.IsNullOrWhiteSpace(BookDrop.Text))
            {
                LibraryAccounting libraryAccounting = new LibraryAccounting
                {
                    AccountID = (int)AccountsDrop.SelectedValue,
                    BookID = (int)BookDrop.SelectedValue,
                    Type = TypeField.Text,
                    IssueDate = IssueDatePicker.Value,
                    CompletionDate = CompletionDatePicker.Value
                };
                try
                {
                    await _libraryAccountingProxy.AddLibraryAccounting(libraryAccounting);
                }
                catch (HttpException ex)
                {
                    MessageBox.Show($"Ошибка:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Заполните данные о штрафе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateButtonOnClick(object sender, EventArgs e)
        {

        }
        private void AccountingViewOnFormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }
    }
}
