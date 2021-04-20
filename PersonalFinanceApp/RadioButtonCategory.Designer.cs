
namespace PersonalFinanceApp
{
    partial class RadioButtonCategory
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
            this.radioBtnTask = new System.Windows.Forms.RadioButton();
            this.radioBtnAppointment = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioBtnTask
            // 
            this.radioBtnTask.AutoSize = true;
            this.radioBtnTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnTask.Location = new System.Drawing.Point(3, 3);
            this.radioBtnTask.Name = "radioBtnTask";
            this.radioBtnTask.Size = new System.Drawing.Size(110, 49);
            this.radioBtnTask.TabIndex = 0;
            this.radioBtnTask.TabStop = true;
            this.radioBtnTask.Text = "Task";
            this.radioBtnTask.UseVisualStyleBackColor = true;
            this.radioBtnTask.CheckedChanged += new System.EventHandler(this.taskChecked);
            // 
            // radioBtnAppointment
            // 
            this.radioBtnAppointment.AutoSize = true;
            this.radioBtnAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAppointment.Location = new System.Drawing.Point(3, 58);
            this.radioBtnAppointment.Name = "radioBtnAppointment";
            this.radioBtnAppointment.Size = new System.Drawing.Size(240, 49);
            this.radioBtnAppointment.TabIndex = 1;
            this.radioBtnAppointment.TabStop = true;
            this.radioBtnAppointment.Text = "Appointment";
            this.radioBtnAppointment.UseVisualStyleBackColor = true;
            this.radioBtnAppointment.CheckedChanged += new System.EventHandler(this.appointmentChecked);
            // 
            // RadioButtonCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioBtnAppointment);
            this.Controls.Add(this.radioBtnTask);
            this.Name = "RadioButtonCategory";
            this.Size = new System.Drawing.Size(248, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnTask;
        private System.Windows.Forms.RadioButton radioBtnAppointment;
    }
}
