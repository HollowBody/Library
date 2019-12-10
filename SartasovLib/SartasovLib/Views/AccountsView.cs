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
            try
            {
                await LoadData();
                InitializeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:Отсутствует подключение к Базе данных. \n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            AccountsGrid.Columns[1].HeaderText = @"Абонемент";
            AccountsGrid.Columns[2].Visible = false;
            AccountsGrid.Columns[3].Visible = false;
            AccountsGrid.Columns[4].HeaderText = @"Имя";
            AccountsGrid.Columns[5].HeaderText = @"Фамилия";
            AccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async void AddButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                await PostLibraryAccount();
                await LoadData();
                InitializeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:Отсутствует подключение к Базе данных. \n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void AccountsViewOnFormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }
        private void SurNameFieldOnValidating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidStringField(SurNameField.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                SurNameField.Select(0, SurNameField.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                ErrorBox.SetError(SurNameField, errorMsg);
            }

        }
        private void FirstNameFieldOnValidating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidStringField(FirstNameField.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                FirstNameField.Select(0, FirstNameField.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                ErrorBox.SetError(FirstNameField, errorMsg);
            }
        }
        private bool ValidStringField(string field, out string errorMsg)
        {
            if (field.Length == 0 || !field.Any(char.IsDigit))
            {
                errorMsg = "SurName is required.";
                return false;
            }
            errorMsg = "";
            return true;
        }
        private void SerialFieldOnValidating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidIntField(SerialField.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                SerialField.Select(0, SerialField.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                ErrorBox.SetError(SerialField, errorMsg);
            }
        }
        private void NumberFieldOnValidating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidIntField(NumberField.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                NumberField.Select(0, NumberField.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                ErrorBox.SetError(NumberField, errorMsg);
            }
        }
        private bool ValidIntField(string field, out string errorMsg)
        {
            if (field.Length == 0 || !field.Any(char.IsLetter))
            {
                errorMsg = "SurName is required.";
                return false;
            }
            errorMsg = "";
            return true;
        }
        private void SurNameField_Validated(object sender, EventArgs e)
        {
            ErrorBox.SetError(SurNameField, "");
        }

        private void FirstNameField_Validated(object sender, EventArgs e)
        {
            ErrorBox.SetError(FirstNameField, "");
        }

        private void SerialField_Validated(object sender, EventArgs e)
        {
            ErrorBox.SetError(SerialField, "");
        }

        private void NumberField_Validated(object sender, EventArgs e)
        {
            ErrorBox.SetError(NumberField, "");
        }
    }
}
