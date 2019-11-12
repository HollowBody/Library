using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SartasovLib.Views
{
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void BooksAccountingButtonOnClick(object sender, EventArgs e)
        {
            AccountingView accountingView = new AccountingView();
            accountingView.Show(this);
        }

        private void PenaltiesAccountingButtonOnClick(object sender, EventArgs e)
        {
            PenaltiesAccountingView penaltiesAccountingView = new PenaltiesAccountingView();
            penaltiesAccountingView.Show(this);
        }

        private void BooksButtonOnClick(object sender, EventArgs e)
        {
            BooksView booksView = new BooksView();
            booksView.Show(this);
        }

        private void PenaltiesButtonOnClick(object sender, EventArgs e)
        {
            PenaltiesView penaltiesView = new PenaltiesView();
            penaltiesView.Show(this);
        }

        private void AccountsButtonOnClick(object sender, EventArgs e)
        {
            AccountsView accountsView = new AccountsView();
            accountsView.Show(this);
        }
    }
}
