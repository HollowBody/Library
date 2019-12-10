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
    public partial class PenaltiesView : Form
    {
        private readonly PenaltiesProxy _penaltiesProxy;
        public PenaltiesView()
        {
            InitializeComponent();
            _penaltiesProxy = new PenaltiesProxy();
        }
        private async void PenaltiesViewOnLoad(object sender, EventArgs e)
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
                DataSource = await GetPenalties()
            };
            PenaltiesGrid.DataSource = accountsBindingSource;
        }
        private async Task<IEnumerable<Penalty>> GetPenalties()
        {
            var penalties = await _penaltiesProxy.GetPenalties();
            return penalties;
        }
        private void InitializeView()
        {
            PenaltiesGrid.Columns[0].HeaderText = @"№";
            PenaltiesGrid.Columns[1].HeaderText = @"Тип";
            PenaltiesGrid.Columns[2].HeaderText = @"Дата";
            PenaltiesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async void AddButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                await PostPenalty();
                await LoadData();
                InitializeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:Отсутствует подключение к Базе данных. \n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task PostPenalty()
        {
            if (!string.IsNullOrWhiteSpace(DateField.Text) && !string.IsNullOrWhiteSpace(TypeField.Text))
            {
                Penalty penalty = new Penalty
                {
                    DateFrom = DateField.Value,
                    Type = TypeField.Text
                };
                try
                {
                    await _penaltiesProxy.AddPenalty(penalty);
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

        private void PenaltiesViewOnFormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }
    }
}
