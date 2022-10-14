namespace Pomodoro
{
    partial class FormForgotPassword
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
            this.btnSend = new ReaLTaiizor.Controls.HopeRoundButton();
            this.txtBoxSecretAnswer = new System.Windows.Forms.TextBox();
            this.txtBoxSecretQuestion = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.btnChk = new ReaLTaiizor.Controls.HopeRoundButton();
            this.labelUserName = new System.Windows.Forms.Label();
            this.gpbSecretQuestion = new System.Windows.Forms.GroupBox();
            this.gpbSecretQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSend.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSend.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSend.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSend.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSend.Location = new System.Drawing.Point(6, 74);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(168)))));
            this.btnSend.Size = new System.Drawing.Size(70, 22);
            this.btnSend.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.TextColor = System.Drawing.Color.White;
            this.btnSend.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxSecretAnswer
            // 
            this.txtBoxSecretAnswer.Location = new System.Drawing.Point(6, 47);
            this.txtBoxSecretAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSecretAnswer.Name = "txtBoxSecretAnswer";
            this.txtBoxSecretAnswer.Size = new System.Drawing.Size(177, 23);
            this.txtBoxSecretAnswer.TabIndex = 10;
            // 
            // txtBoxSecretQuestion
            // 
            this.txtBoxSecretQuestion.Location = new System.Drawing.Point(6, 20);
            this.txtBoxSecretQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSecretQuestion.Name = "txtBoxSecretQuestion";
            this.txtBoxSecretQuestion.ReadOnly = true;
            this.txtBoxSecretQuestion.Size = new System.Drawing.Size(177, 23);
            this.txtBoxSecretQuestion.TabIndex = 12;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(12, 24);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(177, 23);
            this.txtBoxUserName.TabIndex = 13;
            // 
            // btnChk
            // 
            this.btnChk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnChk.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnChk.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnChk.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChk.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChk.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnChk.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnChk.Location = new System.Drawing.Point(12, 51);
            this.btnChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChk.Name = "btnChk";
            this.btnChk.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(168)))));
            this.btnChk.Size = new System.Drawing.Size(70, 22);
            this.btnChk.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnChk.TabIndex = 14;
            this.btnChk.Text = "Check";
            this.btnChk.TextColor = System.Drawing.Color.White;
            this.btnChk.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnChk.Click += new System.EventHandler(this.btnChk_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.Location = new System.Drawing.Point(12, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(65, 13);
            this.labelUserName.TabIndex = 15;
            this.labelUserName.Text = "User Name:";
            // 
            // gpbSecretQuestion
            // 
            this.gpbSecretQuestion.Controls.Add(this.txtBoxSecretAnswer);
            this.gpbSecretQuestion.Controls.Add(this.btnSend);
            this.gpbSecretQuestion.Controls.Add(this.txtBoxSecretQuestion);
            this.gpbSecretQuestion.Location = new System.Drawing.Point(12, 77);
            this.gpbSecretQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSecretQuestion.Name = "gpbSecretQuestion";
            this.gpbSecretQuestion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSecretQuestion.Size = new System.Drawing.Size(210, 102);
            this.gpbSecretQuestion.TabIndex = 17;
            this.gpbSecretQuestion.TabStop = false;
            this.gpbSecretQuestion.Text = "Secret Question:";
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 186);
            this.Controls.Add(this.gpbSecretQuestion);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.btnChk);
            this.Controls.Add(this.txtBoxUserName);
            this.MaximumSize = new System.Drawing.Size(250, 225);
            this.MinimumSize = new System.Drawing.Size(250, 225);
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.FormForgotPassword_Load);
            this.gpbSecretQuestion.ResumeLayout(false);
            this.gpbSecretQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnSend;
        private TextBox txtBoxSecretAnswer;
        private TextBox txtBoxSecretQuestion;
        private TextBox txtBoxUserName;
        private ReaLTaiizor.Controls.HopeRoundButton btnChk;
        private Label labelUserName;
        private GroupBox gpbSecretQuestion;
    }
}