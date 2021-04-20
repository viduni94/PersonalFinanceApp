
namespace PersonalFinanceApp
{
    partial class EventForm
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
            this.lblAddNewEvent = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.lblOccurrence = new System.Windows.Forms.Label();
            this.occurrence = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.lblGoToDashboard = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAddNewEvent
            // 
            this.lblAddNewEvent.AutoSize = true;
            this.lblAddNewEvent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewEvent.Location = new System.Drawing.Point(615, 46);
            this.lblAddNewEvent.Name = "lblAddNewEvent";
            this.lblAddNewEvent.Size = new System.Drawing.Size(376, 65);
            this.lblAddNewEvent.TabIndex = 0;
            this.lblAddNewEvent.Text = "Add New Event";
            // 
            // date
            // 
            this.date.CustomFormat = "";
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(753, 230);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(406, 50);
            this.date.TabIndex = 1;
            this.date.Value = new System.DateTime(2021, 4, 20, 5, 35, 40, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(571, 230);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 45);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(571, 315);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 45);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title :";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(753, 315);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(406, 50);
            this.title.TabIndex = 4;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(509, 403);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(166, 45);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location :";
            // 
            // location
            // 
            this.location.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(753, 403);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(406, 50);
            this.location.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(500, 497);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(175, 45);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category :";
            // 
            // category
            // 
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Task",
            "Appointment"});
            this.category.Location = new System.Drawing.Point(753, 497);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(406, 53);
            this.category.TabIndex = 8;
            // 
            // lblOccurrence
            // 
            this.lblOccurrence.AutoSize = true;
            this.lblOccurrence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrence.Location = new System.Drawing.Point(474, 591);
            this.lblOccurrence.Name = "lblOccurrence";
            this.lblOccurrence.Size = new System.Drawing.Size(205, 45);
            this.lblOccurrence.TabIndex = 9;
            this.lblOccurrence.Text = "Occurrence :";
            // 
            // occurrence
            // 
            this.occurrence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.occurrence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occurrence.FormattingEnabled = true;
            this.occurrence.Items.AddRange(new object[] {
            "One-off",
            "Recurring"});
            this.occurrence.Location = new System.Drawing.Point(753, 591);
            this.occurrence.Name = "occurrence";
            this.occurrence.Size = new System.Drawing.Size(406, 53);
            this.occurrence.TabIndex = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(570, 695);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 45);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User :";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.LightGray;
            this.user.Enabled = false;
            this.user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(753, 692);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(406, 50);
            this.user.TabIndex = 13;
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveEvent.Location = new System.Drawing.Point(753, 834);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(215, 69);
            this.btnSaveEvent.TabIndex = 14;
            this.btnSaveEvent.Text = "Save Event";
            this.btnSaveEvent.UseVisualStyleBackColor = false;
            this.btnSaveEvent.Click += new System.EventHandler(this.saveEvent);
            // 
            // lblGoToDashboard
            // 
            this.lblGoToDashboard.AutoSize = true;
            this.lblGoToDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToDashboard.Location = new System.Drawing.Point(25, 969);
            this.lblGoToDashboard.Name = "lblGoToDashboard";
            this.lblGoToDashboard.Size = new System.Drawing.Size(212, 32);
            this.lblGoToDashboard.TabIndex = 15;
            this.lblGoToDashboard.TabStop = true;
            this.lblGoToDashboard.Text = "Go To Dashboard";
            this.lblGoToDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.navigateToDashboard);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1015);
            this.Controls.Add(this.lblGoToDashboard);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.user);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.occurrence);
            this.Controls.Add(this.lblOccurrence);
            this.Controls.Add(this.category);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.location);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblAddNewEvent);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.onFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewEvent;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label lblOccurrence;
        private System.Windows.Forms.ComboBox occurrence;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.LinkLabel lblGoToDashboard;
    }
}