
namespace PersonalFinanceApp
{
    partial class RadioButtonsOccurrence
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
            this.radioBtnOne = new System.Windows.Forms.RadioButton();
            this.radioBtnRec = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioBtnOne
            // 
            this.radioBtnOne.AutoSize = true;
            this.radioBtnOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnOne.Location = new System.Drawing.Point(0, 0);
            this.radioBtnOne.Name = "radioBtnOne";
            this.radioBtnOne.Size = new System.Drawing.Size(162, 49);
            this.radioBtnOne.TabIndex = 0;
            this.radioBtnOne.TabStop = true;
            this.radioBtnOne.Text = "One-off";
            this.radioBtnOne.UseVisualStyleBackColor = true;
            this.radioBtnOne.CheckedChanged += new System.EventHandler(this.oneOffChecked);
            // 
            // radioBtnRec
            // 
            this.radioBtnRec.AutoSize = true;
            this.radioBtnRec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnRec.Location = new System.Drawing.Point(0, 55);
            this.radioBtnRec.Name = "radioBtnRec";
            this.radioBtnRec.Size = new System.Drawing.Size(186, 49);
            this.radioBtnRec.TabIndex = 1;
            this.radioBtnRec.TabStop = true;
            this.radioBtnRec.Text = "Recurring";
            this.radioBtnRec.UseVisualStyleBackColor = true;
            this.radioBtnRec.CheckedChanged += new System.EventHandler(this.recurringChecked);
            // 
            // RadioButtonOccurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioBtnRec);
            this.Controls.Add(this.radioBtnOne);
            this.Name = "RadioButtonOccurrence";
            this.Size = new System.Drawing.Size(186, 118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnOne;
        private System.Windows.Forms.RadioButton radioBtnRec;
    }
}
