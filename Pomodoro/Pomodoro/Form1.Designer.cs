namespace Pomodoro
{
    partial class FormMain
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
            this.btnLogOut = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnSetting = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnReport = new ReaLTaiizor.Controls.HopeRoundButton();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.btnStart = new ReaLTaiizor.Controls.HopeRoundButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnShortBreak = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnLongBreak = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnPomodoro = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnAddTask = new ReaLTaiizor.Controls.HopeRoundButton();
            this.lsbPlannedTasks = new System.Windows.Forms.ListBox();
            this.gpbListPlanned = new ReaLTaiizor.Controls.GroupBox();
            this.dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            this.gpbCurrentTasks = new ReaLTaiizor.Controls.GroupBox();
            this.dungeonComboBox2 = new ReaLTaiizor.Controls.DungeonComboBox();
            this.lsbCurrentTasks = new System.Windows.Forms.ListBox();
            this.aloneProgressBar1 = new ReaLTaiizor.Controls.AloneProgressBar();
            this.groupBoxTimer.SuspendLayout();
            this.gpbListPlanned.SuspendLayout();
            this.gpbCurrentTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnLogOut.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnLogOut.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnLogOut.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnLogOut.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnLogOut.Location = new System.Drawing.Point(902, 9);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.btnLogOut.Size = new System.Drawing.Size(79, 22);
            this.btnLogOut.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextColor = System.Drawing.Color.White;
            this.btnLogOut.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSetting.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSetting.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSetting.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSetting.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSetting.Location = new System.Drawing.Point(818, 9);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.btnSetting.Size = new System.Drawing.Size(79, 22);
            this.btnSetting.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextColor = System.Drawing.Color.White;
            this.btnSetting.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReport
            // 
            this.btnReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnReport.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnReport.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnReport.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReport.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnReport.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnReport.Location = new System.Drawing.Point(734, 9);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.btnReport.Size = new System.Drawing.Size(79, 22);
            this.btnReport.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.TextColor = System.Drawing.Color.White;
            this.btnReport.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.groupBoxTimer.Controls.Add(this.btnStart);
            this.groupBoxTimer.Controls.Add(this.lblTimer);
            this.groupBoxTimer.Controls.Add(this.btnShortBreak);
            this.groupBoxTimer.Controls.Add(this.btnLongBreak);
            this.groupBoxTimer.Controls.Add(this.btnPomodoro);
            this.groupBoxTimer.Location = new System.Drawing.Point(322, 68);
            this.groupBoxTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTimer.Size = new System.Drawing.Size(350, 210);
            this.groupBoxTimer.TabIndex = 5;
            this.groupBoxTimer.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnStart.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnStart.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnStart.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnStart.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnStart.Location = new System.Drawing.Point(115, 156);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.PrimaryColor = System.Drawing.Color.White;
            this.btnStart.Size = new System.Drawing.Size(122, 38);
            this.btnStart.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "START";
            this.btnStart.TextColor = System.Drawing.Color.Maroon;
            this.btnStart.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(59, 44);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(234, 99);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "00:00";
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnShortBreak.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnShortBreak.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnShortBreak.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShortBreak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShortBreak.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnShortBreak.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnShortBreak.Location = new System.Drawing.Point(237, 20);
            this.btnShortBreak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.btnShortBreak.Size = new System.Drawing.Size(105, 22);
            this.btnShortBreak.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnShortBreak.TabIndex = 9;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.TextColor = System.Drawing.Color.White;
            this.btnShortBreak.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnLongBreak.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnLongBreak.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnLongBreak.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLongBreak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLongBreak.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnLongBreak.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnLongBreak.Location = new System.Drawing.Point(127, 20);
            this.btnLongBreak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.btnLongBreak.Size = new System.Drawing.Size(105, 22);
            this.btnLongBreak.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnLongBreak.TabIndex = 8;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.TextColor = System.Drawing.Color.White;
            this.btnLongBreak.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnPomodoro.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnPomodoro.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnPomodoro.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPomodoro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPomodoro.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnPomodoro.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnPomodoro.Location = new System.Drawing.Point(17, 20);
            this.btnPomodoro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.btnPomodoro.Size = new System.Drawing.Size(105, 22);
            this.btnPomodoro.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnPomodoro.TabIndex = 7;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.TextColor = System.Drawing.Color.White;
            this.btnPomodoro.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAddTask.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAddTask.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAddTask.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTask.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAddTask.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAddTask.Location = new System.Drawing.Point(322, 303);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.btnAddTask.Size = new System.Drawing.Size(350, 38);
            this.btnAddTask.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "+Add Task";
            this.btnAddTask.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(121)))), ((int)(((byte)(116)))));
            this.btnAddTask.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lsbPlannedTasks
            // 
            this.lsbPlannedTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.lsbPlannedTasks.ForeColor = System.Drawing.Color.White;
            this.lsbPlannedTasks.FormattingEnabled = true;
            this.lsbPlannedTasks.ItemHeight = 17;
            this.lsbPlannedTasks.Location = new System.Drawing.Point(10, 23);
            this.lsbPlannedTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbPlannedTasks.Name = "lsbPlannedTasks";
            this.lsbPlannedTasks.Size = new System.Drawing.Size(289, 191);
            this.lsbPlannedTasks.TabIndex = 8;
            // 
            // gpbListPlanned
            // 
            this.gpbListPlanned.BackColor = System.Drawing.Color.Transparent;
            this.gpbListPlanned.BackGColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.gpbListPlanned.BaseColor = System.Drawing.Color.Transparent;
            this.gpbListPlanned.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gpbListPlanned.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gpbListPlanned.Controls.Add(this.dungeonComboBox1);
            this.gpbListPlanned.Controls.Add(this.lsbPlannedTasks);
            this.gpbListPlanned.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbListPlanned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.gpbListPlanned.HeaderColor = System.Drawing.Color.White;
            this.gpbListPlanned.Location = new System.Drawing.Point(10, 68);
            this.gpbListPlanned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbListPlanned.MinimumSize = new System.Drawing.Size(119, 38);
            this.gpbListPlanned.Name = "gpbListPlanned";
            this.gpbListPlanned.Padding = new System.Windows.Forms.Padding(4, 21, 4, 4);
            this.gpbListPlanned.Size = new System.Drawing.Size(306, 273);
            this.gpbListPlanned.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gpbListPlanned.TabIndex = 9;
            this.gpbListPlanned.Text = "Planned Tasks";
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
            this.dungeonComboBox1.Location = new System.Drawing.Point(10, 236);
            this.dungeonComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dungeonComboBox1.Name = "dungeonComboBox1";
            this.dungeonComboBox1.Size = new System.Drawing.Size(289, 26);
            this.dungeonComboBox1.StartIndex = 0;
            this.dungeonComboBox1.TabIndex = 9;
            // 
            // gpbCurrentTasks
            // 
            this.gpbCurrentTasks.BackColor = System.Drawing.Color.Transparent;
            this.gpbCurrentTasks.BackGColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.gpbCurrentTasks.BaseColor = System.Drawing.Color.Transparent;
            this.gpbCurrentTasks.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.gpbCurrentTasks.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.gpbCurrentTasks.Controls.Add(this.dungeonComboBox2);
            this.gpbCurrentTasks.Controls.Add(this.lsbCurrentTasks);
            this.gpbCurrentTasks.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbCurrentTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.gpbCurrentTasks.HeaderColor = System.Drawing.Color.White;
            this.gpbCurrentTasks.Location = new System.Drawing.Point(685, 68);
            this.gpbCurrentTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCurrentTasks.MinimumSize = new System.Drawing.Size(119, 38);
            this.gpbCurrentTasks.Name = "gpbCurrentTasks";
            this.gpbCurrentTasks.Padding = new System.Windows.Forms.Padding(4, 21, 4, 4);
            this.gpbCurrentTasks.Size = new System.Drawing.Size(306, 273);
            this.gpbCurrentTasks.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.gpbCurrentTasks.TabIndex = 10;
            this.gpbCurrentTasks.Text = "Current Tasks";
            // 
            // dungeonComboBox2
            // 
            this.dungeonComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonComboBox2.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.dungeonComboBox2.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.dungeonComboBox2.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.dungeonComboBox2.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dungeonComboBox2.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.dungeonComboBox2.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonComboBox2.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.dungeonComboBox2.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.dungeonComboBox2.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dungeonComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dungeonComboBox2.DropDownHeight = 100;
            this.dungeonComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dungeonComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.dungeonComboBox2.FormattingEnabled = true;
            this.dungeonComboBox2.HoverSelectionColor = System.Drawing.Color.Empty;
            this.dungeonComboBox2.IntegralHeight = false;
            this.dungeonComboBox2.ItemHeight = 20;
            this.dungeonComboBox2.Location = new System.Drawing.Point(10, 236);
            this.dungeonComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dungeonComboBox2.Name = "dungeonComboBox2";
            this.dungeonComboBox2.Size = new System.Drawing.Size(289, 26);
            this.dungeonComboBox2.StartIndex = 0;
            this.dungeonComboBox2.TabIndex = 9;
            // 
            // lsbCurrentTasks
            // 
            this.lsbCurrentTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.lsbCurrentTasks.ForeColor = System.Drawing.Color.White;
            this.lsbCurrentTasks.FormattingEnabled = true;
            this.lsbCurrentTasks.ItemHeight = 17;
            this.lsbCurrentTasks.Location = new System.Drawing.Point(10, 23);
            this.lsbCurrentTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbCurrentTasks.Name = "lsbCurrentTasks";
            this.lsbCurrentTasks.Size = new System.Drawing.Size(289, 191);
            this.lsbCurrentTasks.TabIndex = 8;
            // 
            // aloneProgressBar1
            // 
            this.aloneProgressBar1.BackColor = System.Drawing.Color.Maroon;
            this.aloneProgressBar1.BackgroundColor = System.Drawing.Color.White;
            this.aloneProgressBar1.BorderColor = System.Drawing.Color.Maroon;
            this.aloneProgressBar1.Location = new System.Drawing.Point(13, 52);
            this.aloneProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aloneProgressBar1.Maximum = 100;
            this.aloneProgressBar1.Minimum = 0;
            this.aloneProgressBar1.Name = "aloneProgressBar1";
            this.aloneProgressBar1.Size = new System.Drawing.Size(971, 4);
            this.aloneProgressBar1.Stripes = System.Drawing.Color.White;
            this.aloneProgressBar1.TabIndex = 12;
            this.aloneProgressBar1.Text = "aloneProgressBar1";
            this.aloneProgressBar1.Value = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(991, 374);
            this.Controls.Add(this.aloneProgressBar1);
            this.Controls.Add(this.gpbCurrentTasks);
            this.Controls.Add(this.gpbListPlanned);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.groupBoxTimer);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POMODORO";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            this.gpbListPlanned.ResumeLayout(false);
            this.gpbCurrentTasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnLogOut;
        private ReaLTaiizor.Controls.HopeRoundButton btnSetting;
        private ReaLTaiizor.Controls.HopeRoundButton btnReport;
        private GroupBox groupBoxTimer;
        private ReaLTaiizor.Controls.HopeRoundButton btnPomodoro;
        private ReaLTaiizor.Controls.HopeRoundButton btnStart;
        private Label lblTimer;
        private ReaLTaiizor.Controls.HopeRoundButton btnShortBreak;
        private ReaLTaiizor.Controls.HopeRoundButton btnLongBreak;
        private ReaLTaiizor.Controls.HopeRoundButton btnAddTask;
        private ListBox lsbPlannedTasks;
        private ReaLTaiizor.Controls.GroupBox gpbListPlanned;
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.GroupBox gpbCurrentTasks;
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox2;
        private ListBox lsbCurrentTasks;
        private ReaLTaiizor.Controls.AloneProgressBar aloneProgressBar1;
    }
}