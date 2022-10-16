namespace Pomodoro
{
    partial class FormReport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpbFocusHours = new System.Windows.Forms.GroupBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.btnWeek = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnMonth = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnDay = new ReaLTaiizor.Controls.HopeRoundButton();
            this.gpbActivitySummary = new System.Windows.Forms.GroupBox();
            this.hopeGroupBox2 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.lblImgCalender = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.lblImgClock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpbFocusTimeDetail = new System.Windows.Forms.GroupBox();
            this.listViewDateTaskMinuts = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gpbFocusTimeDetailRanking = new System.Windows.Forms.GroupBox();
            this.listViewUserTime = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpbFocusHours.SuspendLayout();
            this.gpbActivitySummary.SuspendLayout();
            this.hopeGroupBox2.SuspendLayout();
            this.hopeGroupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpbFocusTimeDetail.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gpbFocusTimeDetailRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 505);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpbFocusHours);
            this.tabPage1.Controls.Add(this.gpbActivitySummary);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(458, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gpbFocusHours
            // 
            this.gpbFocusHours.Controls.Add(this.cartesianChart1);
            this.gpbFocusHours.Controls.Add(this.btnWeek);
            this.gpbFocusHours.Controls.Add(this.btnMonth);
            this.gpbFocusHours.Controls.Add(this.btnDay);
            this.gpbFocusHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbFocusHours.Location = new System.Drawing.Point(7, 119);
            this.gpbFocusHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFocusHours.Name = "gpbFocusHours";
            this.gpbFocusHours.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFocusHours.Size = new System.Drawing.Size(444, 350);
            this.gpbFocusHours.TabIndex = 1;
            this.gpbFocusHours.TabStop = false;
            this.gpbFocusHours.Text = "Focus Hours";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.cartesianChart1.Location = new System.Drawing.Point(7, 63);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(423, 271);
            this.cartesianChart1.TabIndex = 3;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnWeek
            // 
            this.btnWeek.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnWeek.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnWeek.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnWeek.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWeek.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeek.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnWeek.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnWeek.Location = new System.Drawing.Point(259, 22);
            this.btnWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWeek.Size = new System.Drawing.Size(88, 22);
            this.btnWeek.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnWeek.TabIndex = 2;
            this.btnWeek.Text = "Week";
            this.btnWeek.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.btnWeek.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // btnMonth
            // 
            this.btnMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnMonth.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnMonth.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnMonth.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMonth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMonth.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnMonth.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnMonth.Location = new System.Drawing.Point(352, 22);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMonth.Size = new System.Drawing.Size(88, 22);
            this.btnMonth.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnMonth.TabIndex = 1;
            this.btnMonth.Text = "Month";
            this.btnMonth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.btnMonth.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // btnDay
            // 
            this.btnDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDay.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnDay.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnDay.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDay.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnDay.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnDay.Location = new System.Drawing.Point(166, 22);
            this.btnDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDay.Name = "btnDay";
            this.btnDay.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDay.Size = new System.Drawing.Size(88, 22);
            this.btnDay.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "Day";
            this.btnDay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(109)))), ((int)(((byte)(105)))));
            this.btnDay.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // gpbActivitySummary
            // 
            this.gpbActivitySummary.Controls.Add(this.hopeGroupBox2);
            this.gpbActivitySummary.Controls.Add(this.hopeGroupBox1);
            this.gpbActivitySummary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbActivitySummary.Location = new System.Drawing.Point(7, 12);
            this.gpbActivitySummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbActivitySummary.Name = "gpbActivitySummary";
            this.gpbActivitySummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbActivitySummary.Size = new System.Drawing.Size(446, 103);
            this.gpbActivitySummary.TabIndex = 0;
            this.gpbActivitySummary.TabStop = false;
            this.gpbActivitySummary.Text = "Activity Summary";
            // 
            // hopeGroupBox2
            // 
            this.hopeGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox2.Controls.Add(this.lblImgCalender);
            this.hopeGroupBox2.Controls.Add(this.label2);
            this.hopeGroupBox2.Controls.Add(this.lblDays);
            this.hopeGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox2.Location = new System.Drawing.Point(153, 33);
            this.hopeGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hopeGroupBox2.Name = "hopeGroupBox2";
            this.hopeGroupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hopeGroupBox2.ShowText = false;
            this.hopeGroupBox2.Size = new System.Drawing.Size(118, 60);
            this.hopeGroupBox2.TabIndex = 2;
            this.hopeGroupBox2.TabStop = false;
            this.hopeGroupBox2.Text = "hopeGroupBox2";
            this.hopeGroupBox2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            // 
            // lblImgCalender
            // 
            this.lblImgCalender.AutoSize = true;
            this.lblImgCalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.lblImgCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.lblImgCalender.Image = global::Pomodoro.Properties.Resources.Calendar_icon;
            this.lblImgCalender.Location = new System.Drawing.Point(12, 8);
            this.lblImgCalender.Name = "lblImgCalender";
            this.lblImgCalender.Size = new System.Drawing.Size(45, 21);
            this.lblImgCalender.TabIndex = 3;
            this.lblImgCalender.Text = "_____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "day accessed";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.lblDays.Location = new System.Drawing.Point(71, 8);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(39, 25);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "0.0";
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.lblImgClock);
            this.hopeGroupBox1.Controls.Add(this.label1);
            this.hopeGroupBox1.Controls.Add(this.lblHours);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(18, 33);
            this.hopeGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(118, 60);
            this.hopeGroupBox1.TabIndex = 1;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "hopeGroupBox1";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            // 
            // lblImgClock
            // 
            this.lblImgClock.AutoSize = true;
            this.lblImgClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.lblImgClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.lblImgClock.Image = global::Pomodoro.Properties.Resources.clock;
            this.lblImgClock.Location = new System.Drawing.Point(9, 8);
            this.lblImgClock.Name = "lblImgClock";
            this.lblImgClock.Size = new System.Drawing.Size(45, 21);
            this.lblImgClock.TabIndex = 2;
            this.lblImgClock.Text = "_____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "hours focused";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(204)))));
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(84)))), ((int)(((byte)(79)))));
            this.lblHours.Location = new System.Drawing.Point(71, 8);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(39, 25);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "0.0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gpbFocusTimeDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(458, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gpbFocusTimeDetail
            // 
            this.gpbFocusTimeDetail.Controls.Add(this.listViewDateTaskMinuts);
            this.gpbFocusTimeDetail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbFocusTimeDetail.Location = new System.Drawing.Point(7, 4);
            this.gpbFocusTimeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFocusTimeDetail.Name = "gpbFocusTimeDetail";
            this.gpbFocusTimeDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFocusTimeDetail.Size = new System.Drawing.Size(446, 465);
            this.gpbFocusTimeDetail.TabIndex = 1;
            this.gpbFocusTimeDetail.TabStop = false;
            this.gpbFocusTimeDetail.Text = "Focus Time Detail";
            // 
            // listViewDateTaskMinuts
            // 
            this.listViewDateTaskMinuts.Location = new System.Drawing.Point(5, 32);
            this.listViewDateTaskMinuts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDateTaskMinuts.Name = "listViewDateTaskMinuts";
            this.listViewDateTaskMinuts.Size = new System.Drawing.Size(436, 430);
            this.listViewDateTaskMinuts.TabIndex = 0;
            this.listViewDateTaskMinuts.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gpbFocusTimeDetailRanking);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(458, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ranking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gpbFocusTimeDetailRanking
            // 
            this.gpbFocusTimeDetailRanking.Controls.Add(this.listViewUserTime);
            this.gpbFocusTimeDetailRanking.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            
            this.gpbFocusTimeDetailRanking.Location = new System.Drawing.Point(7, 7);
            this.gpbFocusTimeDetailRanking.Name = "gpbFocusTimeDetailRanking";
            
            this.gpbFocusTimeDetailRanking.Size = new System.Drawing.Size(510, 620);
            this.gpbFocusTimeDetailRanking.TabIndex = 2;
            this.gpbFocusTimeDetailRanking.TabStop = false;
            this.gpbFocusTimeDetailRanking.Text = "Top 10 Users";
            // 
            // listViewUserTime
            // 
            
            this.listViewUserTime.Location = new System.Drawing.Point(6, 42);
            this.listViewUserTime.Name = "listViewUserTime";
            this.listViewUserTime.Size = new System.Drawing.Size(436, 430);
            this.listViewUserTime.TabIndex = 0;
            this.listViewUserTime.UseCompatibleStateImageBehavior = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 505);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpbFocusHours.ResumeLayout(false);
            this.gpbActivitySummary.ResumeLayout(false);
            this.hopeGroupBox2.ResumeLayout(false);
            this.hopeGroupBox2.PerformLayout();
            this.hopeGroupBox1.ResumeLayout(false);
            this.hopeGroupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gpbFocusTimeDetail.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gpbFocusTimeDetailRanking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox gpbFocusHours;
        private GroupBox gpbActivitySummary;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox2;
        private Label label2;
        private Label lblDays;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private Label label1;
        private Label lblHours;
        private Label lblImgCalender;
        private Label lblImgClock;
        private ReaLTaiizor.Controls.HopeRoundButton btnDay;
        private ReaLTaiizor.Controls.HopeRoundButton btnMonth;
        private ReaLTaiizor.Controls.HopeRoundButton btnWeek;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private GroupBox gpbFocusTimeDetail;
        private ListView listViewDateTaskMinuts;
        private GroupBox gpbFocusTimeDetailRanking;
        private ListView listViewUserTime;
    }
}