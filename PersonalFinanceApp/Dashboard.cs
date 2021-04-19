using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewTransaction(object sender, EventArgs e)
        {
            TransactionForm newTransactionFormWindow = new TransactionForm();
            newTransactionFormWindow.Activate();
            newTransactionFormWindow.ShowDialog();
        }

        private void addNewContact(object sender, EventArgs e)
        {
            ContactForm newContactFormWindow = new ContactForm();
            newContactFormWindow.Activate();
            newContactFormWindow.ShowDialog();
        }
    }
}
