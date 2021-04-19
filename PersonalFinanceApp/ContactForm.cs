using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

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

        private void allowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void saveContact(object sender, EventArgs e)
        {
            ContactModel contactModel = new ContactModel();
            contactModel.SaveContact(this.firstName.Text, this.lastName.Text, int.Parse(this.contactNo.Text));

            this.Hide();
            MessageBox.Show("Contact saved");
        }
    }
}
