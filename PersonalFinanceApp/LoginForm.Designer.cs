
namespace PersonalFinanceApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.loginImage = new System.Windows.Forms.PictureBox();
            this.lblExitLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // inputUsername
            // 
            this.inputUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsername.Location = new System.Drawing.Point(434, 339);
            this.inputUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(421, 50);
            this.inputUsername.TabIndex = 0;
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.Location = new System.Drawing.Point(434, 454);
            this.inputPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(421, 50);
            this.inputPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(544, 540);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(190, 59);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.login);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUsername.Location = new System.Drawing.Point(426, 292);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(163, 45);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPassword.Location = new System.Drawing.Point(426, 407);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(153, 45);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // loginImage
            // 
            this.loginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginImage.Image = ((System.Drawing.Image)(resources.GetObject("loginImage.Image")));
            this.loginImage.Location = new System.Drawing.Point(557, 79);
            this.loginImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(187, 187);
            this.loginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loginImage.TabIndex = 6;
            this.loginImage.TabStop = false;
            // 
            // lblExitLink
            // 
            this.lblExitLink.AutoSize = true;
            this.lblExitLink.Location = new System.Drawing.Point(20, 705);
            this.lblExitLink.Name = "lblExitLink";
            this.lblExitLink.Size = new System.Drawing.Size(160, 25);
            this.lblExitLink.TabIndex = 7;
            this.lblExitLink.TabStop = true;
            this.lblExitLink.Text = "Exit Application";
            this.lblExitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1266, 745);
            this.Controls.Add(this.lblExitLink);
            this.Controls.Add(this.loginImage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.LinkLabel lblExitLink;
    }
}

