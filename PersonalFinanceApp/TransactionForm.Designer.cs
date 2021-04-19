
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
            this.datePickerForTx = new System.Windows.Forms.DateTimePicker();
            this.lblEnterDate = new System.Windows.Forms.Label();
            this.lblNoOfTx = new System.Windows.Forms.Label();
            this.inputNoOfTx = new System.Windows.Forms.TextBox();
            this.btnEnterNoOfTx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewTx
            // 
            this.lblNewTx.AutoSize = true;
            this.lblNewTx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewTx.Location = new System.Drawing.Point(605, 38);
            this.lblNewTx.Name = "lblNewTx";
            this.lblNewTx.Size = new System.Drawing.Size(566, 65);
            this.lblNewTx.TabIndex = 0;
            this.lblNewTx.Text = "Add New Transaction(s)";
            // 
            // lblGoToDashboard
            // 
            this.lblGoToDashboard.AutoSize = true;
            this.lblGoToDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoToDashboard.Location = new System.Drawing.Point(29, 1236);
            this.lblGoToDashboard.Name = "lblGoToDashboard";
            this.lblGoToDashboard.Size = new System.Drawing.Size(271, 32);
            this.lblGoToDashboard.TabIndex = 1;
            this.lblGoToDashboard.TabStop = true;
            this.lblGoToDashboard.Text = "Go Back To Dashboard";
            this.lblGoToDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.navigateToDashboard);
            // 
            // datePickerForTx
            // 
            this.datePickerForTx.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerForTx.CustomFormat = "yyyy-MM-dd";
            this.datePickerForTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerForTx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerForTx.Location = new System.Drawing.Point(939, 202);
            this.datePickerForTx.Name = "datePickerForTx";
            this.datePickerForTx.Size = new System.Drawing.Size(270, 50);
            this.datePickerForTx.TabIndex = 2;
            // 
            // lblEnterDate
            // 
            this.lblEnterDate.AutoSize = true;
            this.lblEnterDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterDate.Location = new System.Drawing.Point(399, 202);
            this.lblEnterDate.Name = "lblEnterDate";
            this.lblEnterDate.Size = new System.Drawing.Size(493, 45);
            this.lblEnterDate.TabIndex = 3;
            this.lblEnterDate.Text = "Pick date to enter transactions :";
            // 
            // lblNoOfTx
            // 
            this.lblNoOfTx.AutoSize = true;
            this.lblNoOfTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoOfTx.Location = new System.Drawing.Point(202, 274);
            this.lblNoOfTx.Name = "lblNoOfTx";
            this.lblNoOfTx.Size = new System.Drawing.Size(690, 45);
            this.lblNoOfTx.TabIndex = 4;
            this.lblNoOfTx.Text = "How many transactions do you want to add?";
            // 
            // inputNoOfTx
            // 
            this.inputNoOfTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNoOfTx.Location = new System.Drawing.Point(939, 274);
            this.inputNoOfTx.Name = "inputNoOfTx";
            this.inputNoOfTx.Size = new System.Drawing.Size(270, 50);
            this.inputNoOfTx.TabIndex = 5;
            // 
            // btnEnterNoOfTx
            // 
            this.btnEnterNoOfTx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnterNoOfTx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterNoOfTx.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnterNoOfTx.Location = new System.Drawing.Point(1247, 273);
            this.btnEnterNoOfTx.Name = "btnEnterNoOfTx";
            this.btnEnterNoOfTx.Size = new System.Drawing.Size(160, 51);
            this.btnEnterNoOfTx.TabIndex = 6;
            this.btnEnterNoOfTx.Text = "Submit";
            this.btnEnterNoOfTx.UseVisualStyleBackColor = false;
            this.btnEnterNoOfTx.Click += new System.EventHandler(this.submitNoOfTransactions);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1299);
            this.Controls.Add(this.btnEnterNoOfTx);
            this.Controls.Add(this.inputNoOfTx);
            this.Controls.Add(this.lblNoOfTx);
            this.Controls.Add(this.lblEnterDate);
            this.Controls.Add(this.datePickerForTx);
            this.Controls.Add(this.lblGoToDashboard);
            this.Controls.Add(this.lblNewTx);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewTx;
        private System.Windows.Forms.LinkLabel lblGoToDashboard;
        private System.Windows.Forms.DateTimePicker datePickerForTx;
        private System.Windows.Forms.Label lblEnterDate;
        private System.Windows.Forms.Label lblNoOfTx;
        private System.Windows.Forms.TextBox inputNoOfTx;
        private System.Windows.Forms.Button btnEnterNoOfTx;
    }
}