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
using LibraryApi.Models;
using SartasovLib.Models;
using SartasovLib.Proxy;

namespace SartasovLib.Views
{
    public partial class PenaltiesAccountingView : Form
    {
        private PenaltiesAccountingProxy _penaltiesAccountingProxy;
        private PenaltiesProxy _penaltiesProxy;
        private AccountsProxy _accountsProxy;
        public PenaltiesAccountingView()
        {
            InitializeComponent();
            _penaltiesAccountingProxy = new PenaltiesAccountingProxy();
            _penaltiesProxy = new PenaltiesProxy();
            _accountsProxy = new AccountsProxy();
        }
        private async void PenaltiesAccountingViewOnLoad(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
                await AccountsLoad();
                await PenaltyTypeLoad();
                InitializeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:Отсутствует подключение к Базе данных. \n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadData()
        {
            BindingSource penaltyAccountingBindingSource = new BindingSource
            {
                DataSource = await GetPenaltiesAccountingsInfo()
            };
            PenaltiesAccountingGrid.DataSource = penaltyAccountingBindingSource;
        }
        private async Task<IEnumerable<PenaltiesAccountingsInfo>> GetPenaltiesAccountingsInfo()
        {
            var penaltiesAccountingsInfo = await _penaltiesAccountingProxy.GetPenaltiesAccountingsInfo();
            return penaltiesAccountingsInfo;
        }
        private void InitializeView()
        {
            PenaltiesAccountingGrid.Columns[0].HeaderText = @"№";
            PenaltiesAccountingGrid.Columns[1].HeaderText = @"Абонемент";
            PenaltiesAccountingGrid.Columns[2].HeaderText = @"Имя";
            PenaltiesAccountingGrid.Columns[3].HeaderText = @"Фамиилия";
            PenaltiesAccountingGrid.Columns[4].HeaderText = @"Тип";
            PenaltiesAccountingGrid.Columns[5].HeaderText = @"Сумма";
            PenaltiesAccountingGrid.Columns[6].HeaderText = @"Дата";
            PenaltiesAccountingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async Task AccountsLoad()
        {
            var accounts = await _accountsProxy.GetAccountsInfo();
            //_accountsBindingSource.DataSource = accounts;
            AccountsDrop.DataSource = accounts;
            AccountsDrop.DisplayMember = "AccountData";
            AccountsDrop.ValueMember = "AccountID";
        }
        private async Task PenaltyTypeLoad()
        {
            var penalties = await _penaltiesProxy.GetPenalties();
            //_accountsBindingSource.DataSource = accounts;
            TypeDrop.DataSource = penalties;
            TypeDrop.DisplayMember = "Type";
            TypeDrop.ValueMember = "PenaltyID";
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
                MessageBox.Show($"Ошибка:Отсутствует подключение к Базе данных. \n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task PostPenalty()
        {
            if (!string.IsNullOrWhiteSpace(AccountsDrop.Text) && !string.IsNullOrWhiteSpace(TypeDrop.Text) && !string.IsNullOrWhiteSpace(SumField.Text))
            {
                PenaltiesAccounting penaltiesAccounting = new PenaltiesAccounting
                {
                    AccountID = (int)AccountsDrop.SelectedValue,
                    Date = DateTime.Now,
                    PenaltyID = (int)TypeDrop.SelectedValue,
                    Sum = Convert.ToDouble(SumField.Text)
                };
                try
                {
                    await _penaltiesAccountingProxy.AddPenaltiesAccounting(penaltiesAccounting);
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
        private void DeleteButtonOnClick(object sender, EventArgs e)
        {

        }
        private void PenaltiesAccountingViewOnFormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }


    }
}
