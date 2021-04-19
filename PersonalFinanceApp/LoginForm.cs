using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonalFinanceApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void login(object sender, EventArgs e)
        {
            myFinanceDbFileEntities db = new myFinanceDbFileEntities();
            var count = db.Users.Where(element => element.username == inputUsername.Text && element.password == inputPassword.Text).Count();

            if (count.ToString() == "1")
            {
                this.Hide();
                Dashboard myDashboard = new Dashboard();
                myDashboard.Activate();
                myDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
