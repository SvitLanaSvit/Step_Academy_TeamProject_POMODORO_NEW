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
            this.btnOKAddTask = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnCancelAddTask = new ReaLTaiizor.Controls.HopeRoundButton();
            this.nudEstPomodoros = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstPomodoros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTask.ForeColor = System.Drawing.Color.Black;
            this.txtTask.Location = new System.Drawing.Point(10, 9);
            this.txtTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTask.Name = "txtTask";
            this.txtTask.PlaceholderText = "What are you working on?";
            this.txtTask.Size = new System.Drawing.Size(444, 22);
            this.txtTask.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Est Pomodoros";
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
            this.btnOKAddTask.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnOKAddTask.Click += new System.EventHandler(this.OnButtonOkClick);
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
            this.btnCancelAddTask.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnCancelAddTask.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // nudEstPomodoros
            // 
            this.nudEstPomodoros.Location = new System.Drawing.Point(10, 61);
            this.nudEstPomodoros.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudEstPomodoros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEstPomodoros.Name = "nudEstPomodoros";
            this.nudEstPomodoros.Size = new System.Drawing.Size(87, 23);
            this.nudEstPomodoros.TabIndex = 5;
            this.nudEstPomodoros.ThousandsSeparator = true;
            this.nudEstPomodoros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 171);
            this.Controls.Add(this.nudEstPomodoros);
            this.Controls.Add(this.btnCancelAddTask);
            this.Controls.Add(this.btnOKAddTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTask);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Task";
            ((System.ComponentModel.ISupportInitialize)(this.nudEstPomodoros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTask;
        private Label label1;
        private ReaLTaiizor.Controls.HopeRoundButton btnOKAddTask;
        private ReaLTaiizor.Controls.HopeRoundButton btnCancelAddTask;
        private NumericUpDown nudEstPomodoros;
    }
}