
namespace PersonalFinanceApp
{
    partial class RadioButtonsType
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
            this.radioBtnIncome = new System.Windows.Forms.RadioButton();
            this.radioBtnExpense = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioBtnIncome
            // 
            this.radioBtnIncome.AutoSize = true;
            this.radioBtnIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnIncome.Location = new System.Drawing.Point(0, 0);
            this.radioBtnIncome.Name = "radioBtnIncome";
            this.radioBtnIncome.Size = new System.Drawing.Size(157, 49);
            this.radioBtnIncome.TabIndex = 0;
            this.radioBtnIncome.TabStop = true;
            this.radioBtnIncome.Text = "Income";
            this.radioBtnIncome.UseVisualStyleBackColor = true;
            this.radioBtnIncome.CheckedChanged += new System.EventHandler(this.incomeChecked);
            // 
            // radioBtnExpense
            // 
            this.radioBtnExpense.AutoSize = true;
            this.radioBtnExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnExpense.Location = new System.Drawing.Point(0, 55);
            this.radioBtnExpense.Name = "radioBtnExpense";
            this.radioBtnExpense.Size = new System.Drawing.Size(167, 49);
            this.radioBtnExpense.TabIndex = 1;
            this.radioBtnExpense.TabStop = true;
            this.radioBtnExpense.Text = "Expense";
            this.radioBtnExpense.UseVisualStyleBackColor = true;
            this.radioBtnExpense.CheckedChanged += new System.EventHandler(this.expenseChecked);
            // 
            // RadioButtonsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.radioBtnExpense);
            this.Controls.Add(this.radioBtnIncome);
            this.Name = "RadioButtonsType";
            this.Size = new System.Drawing.Size(170, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnIncome;
        private System.Windows.Forms.RadioButton radioBtnExpense;
    }
}
