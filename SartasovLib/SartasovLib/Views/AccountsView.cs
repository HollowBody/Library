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
using System.Web;
using System.Windows.Forms;

namespace SartasovLib.Views
{
    public partial class AccountsView : Form
    {
        private readonly AccountsProxy _accountsProxy;
        public AccountsView()
        {
            InitializeComponent();
            _accountsProxy = new AccountsProxy();
        }
        private async void AccountsViewOnLoad(object sender, EventArgs e)
        {
            await LoadData();
            InitializeView();
        }
        private async Task LoadData()
        {
            BindingSource accountsBindingSource = new BindingSource
            {
                DataSource = await GetLibraryAccounts()
            };
            AccountsGrid.DataSource = accountsBindingSource;
        }
        private async Task<IEnumerable<LibraryAccount>> GetLibraryAccounts()
        {
            var libraryAccounts = await _accountsProxy.GetLibraryAccounts();
            return libraryAccounts;
        }
        private void InitializeView()
        {
            AccountsGrid.Columns[0].HeaderText = @"№";
            AccountsGrid.Columns[1].HeaderText = @"Фамилия";
            AccountsGrid.Columns[2].HeaderText = @"Имя";
            AccountsGrid.Columns[3].Visible = false;
            AccountsGrid.Columns[4].Visible = false;
            AccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async void AddButtonOnClick(object sender, EventArgs e)
        {
            await PostLibraryAccount();
            await LoadData();
            InitializeView();
        }
        private async Task PostLibraryAccount()
        {
            if (!string.IsNullOrWhiteSpace(SurNameField.Text) && !string.IsNullOrWhiteSpace(FirstNameField.Text) && !string.IsNullOrWhiteSpace(SerialField.Text) && !string.IsNullOrWhiteSpace(NumberField.Text))
            {
                var accountNumber = await GenerateAccountNumber();               

                LibraryAccount libraryAccount = new LibraryAccount
                {
                    SurName = SurNameField.Text,
                    FirstName = FirstNameField.Text,
                    PassportSerial = Convert.ToInt32(SerialField.Text),
                    PassportNumber = Convert.ToInt32(NumberField.Text),
                    AccountNumber = accountNumber
                };
                try
                {
                    await _accountsProxy.AddLibraryAccount(libraryAccount);
                }
                catch (HttpException ex)
                {
                    MessageBox.Show($"Ошибка:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Укажите данные о человеке в верном формате", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> AccountNumbersIsValid(string accountNumber)
        {
            var isValid = true;
            var accounts = await _accountsProxy.GetLibraryAccounts();
            foreach (var account in accounts)
            {
                if (account.AccountNumber.Equals(accountNumber))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        private async Task<string> GenerateAccountNumber()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var accountNumber = new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            if (await AccountNumbersIsValid(accountNumber))
            {
                return accountNumber;
            }
            else
            {
                await GenerateAccountNumber();
                return null;
            }
        }

        private void ChangeButtonOnClick(object sender, EventArgs e)
        {

        }

        private void DeleteButtonOnClick(object sender, EventArgs e)
        {

        }


    }
}
