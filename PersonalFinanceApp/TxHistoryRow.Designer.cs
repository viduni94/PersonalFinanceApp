
namespace PersonalFinanceApp
{
    partial class TxHistoryRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.occurrence = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(30, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 45);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(195, 38);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(130, 45);
            this.amount.TabIndex = 1;
            this.amount.Text = "amount";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(415, 38);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(82, 45);
            this.type.TabIndex = 2;
            this.type.Text = "type";
            // 
            // occurrence
            // 
            this.occurrence.AutoSize = true;
            this.occurrence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occurrence.Location = new System.Drawing.Point(613, 38);
            this.occurrence.Name = "occurrence";
            this.occurrence.Size = new System.Drawing.Size(176, 45);
            this.occurrence.TabIndex = 3;
            this.occurrence.Text = "occurrence";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(993, 38);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(85, 45);
            this.desc.TabIndex = 4;
            this.desc.Text = "desc";
            // 
            // TxHistoryRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.desc);
            this.Controls.Add(this.occurrence);
            this.Controls.Add(this.type);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.lblDate);
            this.Name = "TxHistoryRow";
            this.Size = new System.Drawing.Size(1310, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label amount;
        public System.Windows.Forms.Label type;
        public System.Windows.Forms.Label occurrence;
        public System.Windows.Forms.Label desc;
    }
}
