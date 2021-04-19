
namespace PersonalFinanceApp
{
    partial class ContactForm
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
            this.lblContactForm = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.inputContactNo = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lblGoToDashboard = new System.Windows.Forms.LinkLabel();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblContactForm
            // 
            this.lblContactForm.AutoSize = true;
            this.lblContactForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContactForm.Location = new System.Drawing.Point(677, 84);
            this.lblContactForm.Name = "lblContactForm";
            this.lblContactForm.Size = new System.Drawing.Size(425, 65);
            this.lblContactForm.TabIndex = 0;
            this.lblContactForm.Text = "Add New Contact";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(544, 315);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 45);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputName.Location = new System.Drawing.Point(749, 312);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(550, 50);
            this.inputName.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(463, 408);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(198, 45);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact No:";
            // 
            // inputContactNo
            // 
            this.inputContactNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputContactNo.Location = new System.Drawing.Point(749, 408);
            this.inputContactNo.Name = "inputContactNo";
            this.inputContactNo.Size = new System.Drawing.Size(550, 50);
            this.inputContactNo.TabIndex = 4;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddContact.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddContact.Location = new System.Drawing.Point(761, 566);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(255, 76);
            this.btnAddContact.TabIndex = 5;
            this.btnAddContact.Text = "Save Contact";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.saveContact);
            // 
            // lblGoToDashboard
            // 
            this.lblGoToDashboard.AutoSize = true;
            this.lblGoToDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoToDashboard.Location = new System.Drawing.Point(25, 1236);
            this.lblGoToDashboard.Name = "lblGoToDashboard";
            this.lblGoToDashboard.Size = new System.Drawing.Size(271, 32);
            this.lblGoToDashboard.TabIndex = 6;
            this.lblGoToDashboard.TabStop = true;
            this.lblGoToDashboard.Text = "Go Back To Dashboard";
            this.lblGoToDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.navigateToDashboard);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.Location = new System.Drawing.Point(1541, 1236);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(195, 32);
            this.lblExit.TabIndex = 7;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "Exit Application";
            this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitApplication);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1299);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblGoToDashboard);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.inputContactNo);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblContactForm);
            this.Name = "ContactForm";
            this.Text = "Contact Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox inputContactNo;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.LinkLabel lblGoToDashboard;
        private System.Windows.Forms.LinkLabel lblExit;
    }
}