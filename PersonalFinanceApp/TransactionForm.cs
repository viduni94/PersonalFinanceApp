using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void navigateToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void submitNoOfTransactions(object sender, EventArgs e)
        {

        }
    }
}
