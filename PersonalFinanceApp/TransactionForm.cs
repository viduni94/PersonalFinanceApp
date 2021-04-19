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

        //private List<Object> transactionsList = new List<Object>();
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void navigateToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void onClickGenerateTransactionFormFields(object sender, EventArgs e)
        {
            // Create an array of the required fields
            int noOfFieldsRequired = (int)this.noOfTransactions.Value;
            Label[] labels = new Label[noOfFieldsRequired];
            TextBox[] textBoxTransactionAmounts = new TextBox[noOfFieldsRequired];
            TextBox[] textBoxDescription = new TextBox[noOfFieldsRequired];
            RadioButtonsType[] radioButtonsType = new RadioButtonsType[noOfFieldsRequired];
            RadioButtonsOccurrence[] radioButtonsOcc = new RadioButtonsOccurrence[noOfFieldsRequired];
            Button saveTransactionsBtn = new Button();

            for (int i = 0; i < textBoxTransactionAmounts.Length; i++)
            {
                // Instantiate and configure the transaction labels
                labels[i] = new Label();
                System.Drawing.Point pLabel = new System.Drawing.Point(47, 450 + i * 175);
                labels[i].Location = pLabel;
                labels[i].Size = new System.Drawing.Size(206, 45);
                labels[i].Text = String.Format(Properties.Resources.LABEL_TRANSACTION, (i + 1).ToString());
                this.Controls.Add(labels[i]);

                // Add the income/expense radio buttons
                radioButtonsType[i] = new RadioButtonsType();
                radioButtonsType[i].Location = new System.Drawing.Point(273, 437 + i * 175);
                this.Controls.Add(radioButtonsType[i]);

                // Instantiate and configure the amount text boxes
                textBoxTransactionAmounts[i] = new TextBox();
                System.Drawing.Point p1 = new System.Drawing.Point(472, 450 + i * 175);
                textBoxTransactionAmounts[i].Location = p1;
                textBoxTransactionAmounts[i].Size = new System.Drawing.Size(200, 50);
                textBoxTransactionAmounts[i].PlaceholderText = Properties.Resources.PLACEHOLDER_AMOUNT;
                this.Controls.Add(textBoxTransactionAmounts[i]);

                // Instantiate and configure the description text boxes
                textBoxDescription[i] = new TextBox();
                System.Drawing.Point p2 = new System.Drawing.Point(698, 450 + i * 175);
                textBoxDescription[i].Location = p2;
                textBoxDescription[i].Size = new System.Drawing.Size(454, 120);
                textBoxDescription[i].PlaceholderText = Properties.Resources.PLACEHOLDER_DESCRIPTION;
                textBoxDescription[i].Multiline = true;
                this.Controls.Add(textBoxDescription[i]);

                // Add some mouse events for the text boxes
                textBoxTransactionAmounts[i].MouseEnter += new System.EventHandler(this.textBox_mouseEnter);
                textBoxTransactionAmounts[i].MouseLeave += new System.EventHandler(this.textBox_mouseLeave);
                textBoxDescription[i].MouseEnter += new System.EventHandler(this.textBox_mouseEnter);
                textBoxDescription[i].MouseLeave += new System.EventHandler(this.textBox_mouseLeave);

                // Enable only numbers for the amounts text box
                textBoxTransactionAmounts[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_keyPress);

                // Add the recurring/one-off radio buttons
                radioButtonsOcc[i] = new RadioButtonsOccurrence();
                radioButtonsOcc[i].Location = new System.Drawing.Point(1177, 437 + i * 175);
                this.Controls.Add(radioButtonsOcc[i]);
            }

            saveTransactionsBtn.Location = new System.Drawing.Point(698, 450 + noOfFieldsRequired * 175 + 50);
            saveTransactionsBtn.Size = new System.Drawing.Size(200, 55);
            saveTransactionsBtn.Text = Properties.Resources.BTN_SAVE_TRANSACTION;
            saveTransactionsBtn.Font = new Font(saveTransactionsBtn.Font.Name, 12);
            saveTransactionsBtn.BackColor = Color.LightBlue;
            this.Controls.Add(saveTransactionsBtn);
            saveTransactionsBtn.Click += onClickSaveTransactions;
        }

        private void onClickSaveTransactions(object sender, EventArgs e)
        {
            // to add save transaction code
        }

        private void textBox_mouseEnter(object sender, EventArgs e)
        {
            TextBox tempBox = (TextBox)sender;
            tempBox.BackColor = Color.LightCyan;
        }

        private void textBox_mouseLeave(object sender, EventArgs e)
        {
            TextBox tempBox = (TextBox)sender;
            tempBox.BackColor = Color.White;
        }

        private void textBox_keyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
