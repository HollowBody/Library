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
    public partial class PenaltiesAccountingView : Form
    {
        public PenaltiesAccountingView()
        {
            InitializeComponent();
        }

        private void AddButtonOnClick(object sender, EventArgs e)
        {

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
