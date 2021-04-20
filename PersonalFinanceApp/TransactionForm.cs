using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace PersonalFinanceApp
{
    public partial class TransactionForm : Form
    {
        private List<Transaction> transactionList = new List<Transaction>();
        private int noOfFieldsRequired;
        private TextBox[] textBoxTransactionAmounts;
        private TextBox[] textBoxDescription;
        private RadioButtonsType[] radioButtonsType;
        private RadioButtonsOccurrence[] radioButtonsOcc;

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
            noOfFieldsRequired = (int)this.noOfTransactions.Value;
            Label[] labels = new Label[noOfFieldsRequired];
            textBoxTransactionAmounts = new TextBox[noOfFieldsRequired];
            textBoxDescription = new TextBox[noOfFieldsRequired];
            radioButtonsType = new RadioButtonsType[noOfFieldsRequired];
            radioButtonsOcc = new RadioButtonsOccurrence[noOfFieldsRequired];
            Button saveTransactionsBtn = new Button();

            for (int i = 0; i < textBoxTransactionAmounts.Length; i++)
            {
                // Instantiate and configure the transaction labels
                labels[i] = new Label();
                System.Drawing.Point pLabel = new System.Drawing.Point(77, 450 + i * 175);
                labels[i].Location = pLabel;
                labels[i].Size = new System.Drawing.Size(206, 45);
                labels[i].Text = String.Format(Properties.Resources.LABEL_TRANSACTION, (i + 1).ToString());
                this.Controls.Add(labels[i]);

                // Add the income/expense radio buttons
                radioButtonsType[i] = new RadioButtonsType();
                radioButtonsType[i].Location = new System.Drawing.Point(303, 437 + i * 175);
                this.Controls.Add(radioButtonsType[i]);

                // Instantiate and configure the amount text boxes
                textBoxTransactionAmounts[i] = new TextBox();
                System.Drawing.Point p1 = new System.Drawing.Point(502, 450 + i * 175);
                textBoxTransactionAmounts[i].Location = p1;
                textBoxTransactionAmounts[i].Size = new System.Drawing.Size(200, 50);
                this.Controls.Add(textBoxTransactionAmounts[i]);

                // Instantiate and configure the description text boxes
                textBoxDescription[i] = new TextBox();
                System.Drawing.Point p2 = new System.Drawing.Point(728, 450 + i * 175);
                textBoxDescription[i].Location = p2;
                textBoxDescription[i].Size = new System.Drawing.Size(454, 120);
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
                radioButtonsOcc[i].Location = new System.Drawing.Point(1207, 437 + i * 175);
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
            noOfFieldsRequired = (int)this.noOfTransactions.Value;
            for (int i = 0; i < noOfFieldsRequired; i++)
            {
                Transaction newTransaction = new Transaction();
                newTransaction.date = DateTime.Parse(this.date.Text);
                newTransaction.amount = Decimal.Parse(textBoxTransactionAmounts[i].Text);
                newTransaction.description = textBoxDescription[i].Text;
                newTransaction.occurrence = radioButtonsOcc[i].OneOff
                    ? int.Parse(Properties.Resources.ONEOFF_VALUE)
                    : int.Parse(Properties.Resources.RECURRING_VALUE);
                newTransaction.type = radioButtonsType[i].Income
                    ? int.Parse(Properties.Resources.INCOME_VALUE)
                    : int.Parse(Properties.Resources.EXPENSE_VALUE);
                transactionList.Add(newTransaction);
            }

            TransactionModel transactionModel = new TransactionModel();
            transactionModel.SaveTransaction(transactionList);

            this.Hide();
            MessageBox.Show("Transaction(s) saved");
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
