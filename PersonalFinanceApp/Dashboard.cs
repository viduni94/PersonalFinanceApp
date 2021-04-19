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

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        // Create a single instance of the transaction form
        TransactionForm newTransactionFormWindow = null;
        private void addNewTransaction(object sender, EventArgs e)
        {
            if (this.newTransactionFormWindow == null)
            {
                this.newTransactionFormWindow = new TransactionForm();
            }
            newTransactionFormWindow.AutoScroll = true;
            this.newTransactionFormWindow.Activate();
            this.newTransactionFormWindow.Show();
        }

        // Create a single instance of the contact form
        ContactForm newContactFormWindow = null;
        private void addNewContact(object sender, EventArgs e)
        {
            if (this.newContactFormWindow == null)
            {
                this.newContactFormWindow = new ContactForm();
            }
            this.newContactFormWindow.Activate();
            this.newContactFormWindow.Show();
        }
    }
}
