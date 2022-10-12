namespace Pomodoro
{
    partial class FormSetting
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
            this.gpbTimeMinutes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudShortBreak = new ReaLTaiizor.Controls.FoxNumeric();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLongBreak = new ReaLTaiizor.Controls.FoxNumeric();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPomodoro = new ReaLTaiizor.Controls.FoxNumeric();
            this.gpbAlarmSound = new System.Windows.Forms.GroupBox();
            this.dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            this.btnOkSetting = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnCancelSetting = new ReaLTaiizor.Controls.HopeRoundButton();
            this.gpbTimeMinutes.SuspendLayout();
            this.gpbAlarmSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTimeMinutes
            // 
            this.gpbTimeMinutes.Controls.Add(this.label3);
            this.gpbTimeMinutes.Controls.Add(this.nudShortBreak);
            this.gpbTimeMinutes.Controls.Add(this.label2);
            this.gpbTimeMinutes.Controls.Add(this.nudLongBreak);
            this.gpbTimeMinutes.Controls.Add(this.label1);
            this.gpbTimeMinutes.Controls.Add(this.nudPomodoro);
            this.gpbTimeMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbTimeMinutes.Location = new System.Drawing.Point(10, 9);
            this.gpbTimeMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbTimeMinutes.Name = "gpbTimeMinutes";
            this.gpbTimeMinutes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbTimeMinutes.Size = new System.Drawing.Size(444, 94);
            this.gpbTimeMinutes.TabIndex = 0;
            this.gpbTimeMinutes.TabStop = false;
            this.gpbTimeMinutes.Text = "Time (minutes)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(313, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Short Break";
            // 
            // nudShortBreak
            // 
            this.nudShortBreak.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nudShortBreak.ButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.nudShortBreak.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nudShortBreak.DisabledButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(210)))));
            this.nudShortBreak.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.nudShortBreak.EnabledCalc = true;
            this.nudShortBreak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudShortBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.nudShortBreak.Location = new System.Drawing.Point(312, 45);
            this.nudShortBreak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudShortBreak.Max = 100;
            this.nudShortBreak.Min = 0;
            this.nudShortBreak.Name = "nudShortBreak";
            this.nudShortBreak.Size = new System.Drawing.Size(114, 27);
            this.nudShortBreak.TabIndex = 4;
            this.nudShortBreak.Text = "foxNumeric3";
            this.nudShortBreak.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Long Break";
            // 
            // nudLongBreak
            // 
            this.nudLongBreak.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nudLongBreak.ButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.nudLongBreak.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nudLongBreak.DisabledButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(210)))));
            this.nudLongBreak.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.nudLongBreak.EnabledCalc = true;
            this.nudLongBreak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudLongBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.nudLongBreak.Location = new System.Drawing.Point(168, 45);
            this.nudLongBreak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudLongBreak.Max = 100;
            this.nudLongBreak.Min = 0;
            this.nudLongBreak.Name = "nudLongBreak";
            this.nudLongBreak.Size = new System.Drawing.Size(114, 27);
            this.nudLongBreak.TabIndex = 2;
            this.nudLongBreak.Text = "foxNumeric2";
            this.nudLongBreak.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pomodoro";
            // 
            // nudPomodoro
            // 
            this.nudPomodoro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nudPomodoro.ButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.nudPomodoro.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nudPomodoro.DisabledButtonTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(210)))));
            this.nudPomodoro.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.nudPomodoro.EnabledCalc = true;
            this.nudPomodoro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudPomodoro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.nudPomodoro.Location = new System.Drawing.Point(18, 45);
            this.nudPomodoro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPomodoro.Max = 100;
            this.nudPomodoro.Min = 0;
            this.nudPomodoro.Name = "nudPomodoro";
            this.nudPomodoro.Size = new System.Drawing.Size(114, 27);
            this.nudPomodoro.TabIndex = 0;
            this.nudPomodoro.Text = "foxNumeric1";
            this.nudPomodoro.Value = 0;
            // 
            // gpbAlarmSound
            // 
            this.gpbAlarmSound.Controls.Add(this.dungeonComboBox1);
            this.gpbAlarmSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbAlarmSound.Location = new System.Drawing.Point(10, 107);
            this.gpbAlarmSound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbAlarmSound.Name = "gpbAlarmSound";
            this.gpbAlarmSound.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbAlarmSound.Size = new System.Drawing.Size(444, 94);
            this.gpbAlarmSound.TabIndex = 1;
            this.gpbAlarmSound.TabStop = false;
            this.gpbAlarmSound.Text = "Alarm Sound";
            // 
            // dungeonComboBox1
            // 
            this.dungeonComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonComboBox1.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.dungeonComboBox1.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.dungeonComboBox1.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.dungeonComboBox1.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dungeonComboBox1.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.dungeonComboBox1.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonComboBox1.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.dungeonComboBox1.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.dungeonComboBox1.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dungeonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dungeonComboBox1.DropDownHeight = 100;
            this.dungeonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dungeonComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.dungeonComboBox1.FormattingEnabled = true;
            this.dungeonComboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.dungeonComboBox1.IntegralHeight = false;
            this.dungeonComboBox1.ItemHeight = 20;
            this.dungeonComboBox1.Location = new System.Drawing.Point(168, 40);
            this.dungeonComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dungeonComboBox1.Name = "dungeonComboBox1";
            this.dungeonComboBox1.Size = new System.Drawing.Size(259, 26);
            this.dungeonComboBox1.StartIndex = 0;
            this.dungeonComboBox1.TabIndex = 0;
            // 
            // btnOkSetting
            // 
            this.btnOkSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnOkSetting.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnOkSetting.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnOkSetting.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOkSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOkSetting.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnOkSetting.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnOkSetting.Location = new System.Drawing.Point(10, 281);
            this.btnOkSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOkSetting.Name = "btnOkSetting";
            this.btnOkSetting.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnOkSetting.Size = new System.Drawing.Size(131, 38);
            this.btnOkSetting.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnOkSetting.TabIndex = 2;
            this.btnOkSetting.Text = "OK";
            this.btnOkSetting.TextColor = System.Drawing.Color.White;
            this.btnOkSetting.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // btnCancelSetting
            // 
            this.btnCancelSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCancelSetting.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnCancelSetting.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCancelSetting.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelSetting.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnCancelSetting.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCancelSetting.Location = new System.Drawing.Point(323, 281);
            this.btnCancelSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelSetting.Name = "btnCancelSetting";
            this.btnCancelSetting.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCancelSetting.Size = new System.Drawing.Size(131, 38);
            this.btnCancelSetting.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCancelSetting.TabIndex = 3;
            this.btnCancelSetting.Text = "Cancel";
            this.btnCancelSetting.TextColor = System.Drawing.Color.White;
            this.btnCancelSetting.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 340);
            this.Controls.Add(this.btnCancelSetting);
            this.Controls.Add(this.btnOkSetting);
            this.Controls.Add(this.gpbAlarmSound);
            this.Controls.Add(this.gpbTimeMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Setting";
            this.gpbTimeMinutes.ResumeLayout(false);
            this.gpbTimeMinutes.PerformLayout();
            this.gpbAlarmSound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpbTimeMinutes;
        private Label label3;
        private ReaLTaiizor.Controls.FoxNumeric nudShortBreak;
        private Label label2;
        private ReaLTaiizor.Controls.FoxNumeric nudLongBreak;
        private Label label1;
        private ReaLTaiizor.Controls.FoxNumeric nudPomodoro;
        private GroupBox gpbAlarmSound;
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.HopeRoundButton btnOkSetting;
        private ReaLTaiizor.Controls.HopeRoundButton btnCancelSetting;
    }
}