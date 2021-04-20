
namespace PersonalFinanceApp
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewTx = new System.Windows.Forms.Label();
            this.lblGoToDashboard = new System.Windows.Forms.LinkLabel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblEnterDate = new System.Windows.Forms.Label();
            this.lblNoOfTx = new System.Windows.Forms.Label();
            this.btnEnterNoOfTx = new System.Windows.Forms.Button();
            this.noOfTransactions = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.noOfTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewTx
            // 
            this.lblNewTx.AutoSize = true;
            this.lblNewTx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNewTx.Location = new System.Drawing.Point(558, 30);
            this.lblNewTx.Name = "lblNewTx";
            this.lblNewTx.Size = new System.Drawing.Size(566, 65);
            this.lblNewTx.TabIndex = 0;
            this.lblNewTx.Text = "Add New Transaction(s)";
            // 
            // lblGoToDashboard
            // 
            this.lblGoToDashboard.AutoSize = true;
            this.lblGoToDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGoToDashboard.Location = new System.Drawing.Point(11, 14);
            this.lblGoToDashboard.Name = "lblGoToDashboard";
            this.lblGoToDashboard.Size = new System.Drawing.Size(272, 32);
            this.lblGoToDashboard.TabIndex = 1;
            this.lblGoToDashboard.TabStop = true;
            this.lblGoToDashboard.Text = "Go Back To Dashboard";
            this.lblGoToDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.navigateToDashboard);
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(874, 158);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(260, 50);
            this.date.TabIndex = 2;
            // 
            // lblEnterDate
            // 
            this.lblEnterDate.AutoSize = true;
            this.lblEnterDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnterDate.Location = new System.Drawing.Point(368, 158);
            this.lblEnterDate.Name = "lblEnterDate";
            this.lblEnterDate.Size = new System.Drawing.Size(493, 45);
            this.lblEnterDate.TabIndex = 3;
            this.lblEnterDate.Text = "Pick date to enter transactions :";
            // 
            // lblNoOfTx
            // 
            this.lblNoOfTx.AutoSize = true;
            this.lblNoOfTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNoOfTx.Location = new System.Drawing.Point(171, 214);
            this.lblNoOfTx.Name = "lblNoOfTx";
            this.lblNoOfTx.Size = new System.Drawing.Size(690, 45);
            this.lblNoOfTx.TabIndex = 4;
            this.lblNoOfTx.Text = "How many transactions do you want to add?";
            // 
            // btnEnterNoOfTx
            // 
            this.btnEnterNoOfTx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnterNoOfTx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterNoOfTx.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold);
            this.btnEnterNoOfTx.Location = new System.Drawing.Point(1185, 214);
            this.btnEnterNoOfTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnterNoOfTx.Name = "btnEnterNoOfTx";
            this.btnEnterNoOfTx.Size = new System.Drawing.Size(168, 50);
            this.btnEnterNoOfTx.TabIndex = 6;
            this.btnEnterNoOfTx.Text = "Submit";
            this.btnEnterNoOfTx.UseVisualStyleBackColor = false;
            this.btnEnterNoOfTx.Click += new System.EventHandler(this.onClickGenerateTransactionFormFields);
            // 
            // noOfTransactions
            // 
            this.noOfTransactions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.noOfTransactions.Location = new System.Drawing.Point(874, 214);
            this.noOfTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noOfTransactions.Name = "noOfTransactions";
            this.noOfTransactions.Size = new System.Drawing.Size(260, 50);
            this.noOfTransactions.TabIndex = 7;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1370);
            this.ClientSize = new System.Drawing.Size(1826, 1020);
            this.Controls.Add(this.noOfTransactions);
            this.Controls.Add(this.btnEnterNoOfTx);
            this.Controls.Add(this.lblNoOfTx);
            this.Controls.Add(this.lblEnterDate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblGoToDashboard);
            this.Controls.Add(this.lblNewTx);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.noOfTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewTx;
        private System.Windows.Forms.LinkLabel lblGoToDashboard;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblEnterDate;
        private System.Windows.Forms.Label lblNoOfTx;
        private System.Windows.Forms.Button btnEnterNoOfTx;
        private System.Windows.Forms.NumericUpDown noOfTransactions;
    }
}