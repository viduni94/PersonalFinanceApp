
namespace PersonalFinanceApp
{
    partial class Dashboard
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
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMonthlySum = new System.Windows.Forms.Button();
            this.btnWeeklySum = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnAdddTx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.Location = new System.Drawing.Point(314, 17);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(467, 65);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Transaction History";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(30, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnExit);
            this.splitContainer1.Panel1.Controls.Add(this.btnMonthlySum);
            this.splitContainer1.Panel1.Controls.Add(this.btnWeeklySum);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddContact);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddEvent);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdddTx);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel2.Controls.Add(this.lblDashboardTitle);
            this.splitContainer1.Size = new System.Drawing.Size(1569, 953);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(92, 845);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(325, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.exit);
            // 
            // btnMonthlySum
            // 
            this.btnMonthlySum.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMonthlySum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlySum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMonthlySum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMonthlySum.Location = new System.Drawing.Point(92, 719);
            this.btnMonthlySum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonthlySum.Name = "btnMonthlySum";
            this.btnMonthlySum.Size = new System.Drawing.Size(325, 100);
            this.btnMonthlySum.TabIndex = 4;
            this.btnMonthlySum.Text = "View Monthly Summary";
            this.btnMonthlySum.UseVisualStyleBackColor = false;
            // 
            // btnWeeklySum
            // 
            this.btnWeeklySum.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWeeklySum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeeklySum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnWeeklySum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnWeeklySum.Location = new System.Drawing.Point(92, 592);
            this.btnWeeklySum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklySum.Name = "btnWeeklySum";
            this.btnWeeklySum.Size = new System.Drawing.Size(325, 100);
            this.btnWeeklySum.TabIndex = 3;
            this.btnWeeklySum.Text = "View Weekly Summary";
            this.btnWeeklySum.UseVisualStyleBackColor = false;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddContact.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddContact.Location = new System.Drawing.Point(92, 270);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(325, 56);
            this.btnAddContact.TabIndex = 2;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.addNewContact);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddEvent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddEvent.Location = new System.Drawing.Point(92, 152);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(325, 56);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            // 
            // btnAdddTx
            // 
            this.btnAdddTx.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdddTx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdddTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdddTx.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdddTx.Location = new System.Drawing.Point(92, 38);
            this.btnAdddTx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdddTx.Name = "btnAdddTx";
            this.btnAdddTx.Size = new System.Drawing.Size(325, 56);
            this.btnAdddTx.TabIndex = 0;
            this.btnAdddTx.Text = "Add Transaction";
            this.btnAdddTx.UseVisualStyleBackColor = false;
            this.btnAdddTx.Click += new System.EventHandler(this.addNewTransaction);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1015);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMonthlySum;
        private System.Windows.Forms.Button btnWeeklySum;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnAdddTx;
    }
}