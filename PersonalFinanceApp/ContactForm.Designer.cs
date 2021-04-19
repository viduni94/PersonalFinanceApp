
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.contactNo = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lblGoToDashboard = new System.Windows.Forms.LinkLabel();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.lastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContactForm
            // 
            this.lblContactForm.AutoSize = true;
            this.lblContactForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContactForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblContactForm.Location = new System.Drawing.Point(677, 84);
            this.lblContactForm.Name = "lblContactForm";
            this.lblContactForm.Size = new System.Drawing.Size(425, 65);
            this.lblContactForm.TabIndex = 0;
            this.lblContactForm.Text = "Add New Contact";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(470, 317);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(191, 45);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(749, 312);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(550, 50);
            this.firstName.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(463, 514);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(198, 45);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact No:";
            // 
            // contactNo
            // 
            this.contactNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNo.Location = new System.Drawing.Point(749, 514);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(550, 50);
            this.contactNo.TabIndex = 4;
            this.contactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowOnlyNumbers);
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddContact.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddContact.Location = new System.Drawing.Point(763, 654);
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
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(749, 412);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(550, 50);
            this.lastName.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(476, 412);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(185, 45);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name:";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1299);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblGoToDashboard);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.contactNo);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblContactForm);
            this.Name = "ContactForm";
            this.Text = "Contact Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactForm;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox contactNo;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.LinkLabel lblGoToDashboard;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label lblLastName;
    }
}