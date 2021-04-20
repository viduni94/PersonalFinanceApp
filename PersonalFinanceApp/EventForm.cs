using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            myFinanceDbFileEntities db = new myFinanceDbFileEntities();
            var query = from username in db.Users select username;
            var user = query.ToList();

            this.user.Text = user[0].username;
        }

        private void navigateToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void saveEvent(object sender, EventArgs e)
        {
            EventModel eventModel = new EventModel();
            eventModel.SaveEvent(
                this.title.Text,
                this.location.Text,
                DateTime.Parse(this.date.Text),
                this.category.Text,
                this.occurrence.Text,
                this.user.Text
            );

            this.Hide();
            MessageBox.Show("Event Saved");
        }
    }
}
