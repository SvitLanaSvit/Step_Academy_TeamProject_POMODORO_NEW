namespace Pomodoro
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnForgotPass = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnSignInNewUser = new ReaLTaiizor.Controls.HopeRoundButton();
            this.gpbNewUser = new System.Windows.Forms.GroupBox();
            this.gpbNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(10, 24);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(177, 23);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(10, 66);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(177, 23);
            this.txtUserPassword.TabIndex = 5;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSignIn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSignIn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSignIn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignIn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSignIn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSignIn.Location = new System.Drawing.Point(10, 91);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(168)))));
            this.btnSignIn.Size = new System.Drawing.Size(70, 22);
            this.btnSignIn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextColor = System.Drawing.Color.White;
            this.btnSignIn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnForgotPass.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnForgotPass.DangerColor = System.Drawing.SystemColors.Control;
            this.btnForgotPass.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnForgotPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnForgotPass.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnForgotPass.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnForgotPass.Location = new System.Drawing.Point(10, 118);
            this.btnForgotPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.PrimaryColor = System.Drawing.SystemColors.Control;
            this.btnForgotPass.Size = new System.Drawing.Size(130, 22);
            this.btnForgotPass.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnForgotPass.TabIndex = 7;
            this.btnForgotPass.Text = "Forgot password?";
            this.btnForgotPass.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnForgotPass.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // btnSignInNewUser
            // 
            this.btnSignInNewUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSignInNewUser.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSignInNewUser.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSignInNewUser.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignInNewUser.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignInNewUser.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSignInNewUser.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSignInNewUser.Location = new System.Drawing.Point(5, 29);
            this.btnSignInNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignInNewUser.Name = "btnSignInNewUser";
            this.btnSignInNewUser.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(168)))));
            this.btnSignInNewUser.Size = new System.Drawing.Size(70, 22);
            this.btnSignInNewUser.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSignInNewUser.TabIndex = 8;
            this.btnSignInNewUser.Text = "Sign In";
            this.btnSignInNewUser.TextColor = System.Drawing.Color.White;
            this.btnSignInNewUser.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSignInNewUser.Click += new System.EventHandler(this.btnSignInNewUser_Click);
            // 
            // gpbNewUser
            // 
            this.gpbNewUser.Controls.Add(this.btnSignInNewUser);
            this.gpbNewUser.Location = new System.Drawing.Point(10, 145);
            this.gpbNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbNewUser.Name = "gpbNewUser";
            this.gpbNewUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbNewUser.Size = new System.Drawing.Size(177, 68);
            this.gpbNewUser.TabIndex = 9;
            this.gpbNewUser.TabStop = false;
            this.gpbNewUser.Text = "New User";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 221);
            this.Controls.Add(this.gpbNewUser);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.gpbNewUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private ReaLTaiizor.Controls.HopeRoundButton btnSignIn;
        private ReaLTaiizor.Controls.HopeRoundButton btnForgotPass;
        private ReaLTaiizor.Controls.HopeRoundButton btnSignInNewUser;
        private GroupBox gpbNewUser;
    }
}