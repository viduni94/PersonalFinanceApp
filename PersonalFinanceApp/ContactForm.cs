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
        // Property for contact details
        public ContactDetails contactData { get; set; }
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
            this.contactData.FirstName = this.firstName.Text;
            this.contactData.LastName = this.lastName.Text;
            this.contactData.ContactNo = int.Parse(this.contactNo.Text);
            //this.CreateContact(this.firstName.Text, this.lastName.Text, this.contactNo.Text);
        }

        private void CreateContact(String firstName, String lastName, int contactNo)
        {
            //UserModel userModel = new UserModel();
            //userModel.CreateContact(firstName, lastName, contactNo)
        }
    }
}
