using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

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
            Application.Exit();
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

        EventForm newEventForm = null;
        private void addNewEvent(object sender, EventArgs e)
        {
            if (this.newEventForm == null)
            {
                this.newEventForm = new EventForm();
            }
            this.newEventForm.Activate();
            this.newEventForm.Show();
        }

        private void onDashboardLoad(object sender, EventArgs e)
        {
            // Read from XML
            string workingDirectory = Directory.GetCurrentDirectory();
            XmlTextReader textReader = new XmlTextReader(workingDirectory + @"\myDataFile.xml");
            if (textReader.HasLineInfo())
            {
                textReader.Read();

                List<string> list = new List<string>();

                while (textReader.Read())
                {
                    textReader.MoveToElement();
                    if (textReader.Name == "Transaction")
                    {
                        // The desired node has been found
                        XmlNodeType nType = textReader.NodeType;
                        if (nType == XmlNodeType.Text)
                        {
                            list.Add(textReader.Value.ToString());
                        }
                    }
                }
                textReader.Close();
            }

            // Read from Database and populate data

        }
    }
}
