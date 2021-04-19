using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void navigateToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void exitApplication(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void saveContact(object sender, EventArgs e)
        {

        }
    }
}
