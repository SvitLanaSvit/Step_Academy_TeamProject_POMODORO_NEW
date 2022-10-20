namespace Pomodoro
{
    partial class FormAddTask
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
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEstPomodoros = new ReaLTaiizor.Controls.FoxNumeric();
            this.btnOKAddTask = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnCancelAddTask = new ReaLTaiizor.Controls.HopeRoundButton();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTask.ForeColor = System.Drawing.Color.LightGray;
            this.txtTask.Location = new System.Drawing.Point(10, 9);
            this.txtTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(444, 22);
            this.txtTask.TabIndex = 0;
            this.txtTask.Text = "What are you working for?";
            this.txtTask.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Est Pomodoros";
            this.label1.UseWaitCursor = true;
            // 
            // nudEstPomodoros
            // 
            this.nudEstPomodoros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nudEstPomodoros.ButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.nudEstPomodoros.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nudEstPomodoros.DisabledButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(210)))));
            this.nudEstPomodoros.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.nudEstPomodoros.EnabledCalc = true;
            this.nudEstPomodoros.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudEstPomodoros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.nudEstPomodoros.Location = new System.Drawing.Point(10, 60);
            this.nudEstPomodoros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEstPomodoros.Max = 100;
            this.nudEstPomodoros.Min = 0;
            this.nudEstPomodoros.Name = "nudEstPomodoros";
            this.nudEstPomodoros.Size = new System.Drawing.Size(95, 27);
            this.nudEstPomodoros.TabIndex = 2;
            this.nudEstPomodoros.Text = "foxNumeric1";
            this.nudEstPomodoros.UseWaitCursor = true;
            this.nudEstPomodoros.Value = 0;
            // 
            // btnOKAddTask
            // 
            this.btnOKAddTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnOKAddTask.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnOKAddTask.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnOKAddTask.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOKAddTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOKAddTask.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnOKAddTask.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnOKAddTask.Location = new System.Drawing.Point(10, 117);
            this.btnOKAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOKAddTask.Name = "btnOKAddTask";
            this.btnOKAddTask.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnOKAddTask.Size = new System.Drawing.Size(131, 38);
            this.btnOKAddTask.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnOKAddTask.TabIndex = 3;
            this.btnOKAddTask.Text = "OK";
            this.btnOKAddTask.TextColor = System.Drawing.Color.White;
            this.btnOKAddTask.UseWaitCursor = true;
            this.btnOKAddTask.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnOKAddTask.Click += new System.EventHandler(this.btnOKAddTask_Click);
            // 
            // btnCancelAddTask
            // 
            this.btnCancelAddTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCancelAddTask.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnCancelAddTask.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCancelAddTask.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelAddTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAddTask.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnCancelAddTask.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCancelAddTask.Location = new System.Drawing.Point(324, 117);
            this.btnCancelAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelAddTask.Name = "btnCancelAddTask";
            this.btnCancelAddTask.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCancelAddTask.Size = new System.Drawing.Size(131, 38);
            this.btnCancelAddTask.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCancelAddTask.TabIndex = 4;
            this.btnCancelAddTask.Text = "Cancel";
            this.btnCancelAddTask.TextColor = System.Drawing.Color.White;
            this.btnCancelAddTask.UseWaitCursor = true;
            this.btnCancelAddTask.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnCancelAddTask.Click += new System.EventHandler(this.btnCancelAddTask_Click);
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 171);
            this.Controls.Add(this.btnCancelAddTask);
            this.Controls.Add(this.btnOKAddTask);
            this.Controls.Add(this.nudEstPomodoros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAddTask";
            this.Text = "Add Task";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormAddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTask;
        private Label label1;
        private ReaLTaiizor.Controls.FoxNumeric nudEstPomodoros;
        private ReaLTaiizor.Controls.HopeRoundButton btnOKAddTask;
        private ReaLTaiizor.Controls.HopeRoundButton btnCancelAddTask;
    }
}