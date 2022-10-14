using System.Media;
using Timer = System.Windows.Forms.Timer;
using System.Drawing;
using ReaLTaiizor.Controls;
using Pomodoro.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using Pomodoro.DataBase.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.VisualBasic;

namespace Pomodoro
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //Timer------------------------------------------------------------------------------
        Timer timer = null!;
        int m, s;
        int currentAction;
        bool isRunning = false;
        static string path = "C:\\Users\\Svitlana\\Programierung\\C#TeamWork_2022\\dodomu.wav";
        SoundPlayer player = new SoundPlayer(path);
        internal MyUser currentUser = new();
        internal Settings currentSetings;
        private async void FormMain_Load(object sender, EventArgs e)
        {
            StartDB();
            //CheckDB();
            //CreateForDB();

            FormLogin formLogin = new FormLogin(options);
            formLogin.Owner = this;
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
                {
                    //MessageBox.Show($"{currentUser.Login}, {currentUser.Password}");
                    //lblTimer.Text = "25:00";
                    currentAction = 1;
                    currentSetings = context.PomodoroSettings.First(t => t.UserId == currentUser.Id);
                    m = currentSetings.PomodoroTime;
                    s = 0;
                    lblTimer.Text = $"{m}:00";
                    this.BackColor = Color.FromArgb(215, 84, 79);

                    timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += Timer_Tick;

                    //if (lblTimer.Text.Contains("25:00"))
                    //    m = 25; s = 0;
                    //if (lblTimer.Text.Contains("15:00"))
                    //    m = 15; s = 0;
                    //if (lblTimer.Text.Contains("05:00"))
                    //    m = 5; s = 0;

                    aloneProgressBar1.Value = 0;
                    aloneProgressBar1.Maximum = m * 60 + s;
                    await UpdateAllListBoxes();
                }
            }
            else
            {
                this.Close();
            }

        }

        private async Task UpdateAllListBoxes()
        {
            using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                var plannedTasks = await context.Tasks.Where(e => e.UserId == currentUser.Id && e.IsCurrent == false).ToListAsync();
                lsbPlannedTasks.DataSource = null;
                lsbPlannedTasks.DisplayMember = nameof(MyTask.Name);
                lsbPlannedTasks.ValueMember = "Id";
                lsbPlannedTasks.DataSource = plannedTasks;
                var currentTasks = await context.Tasks.Where(e => e.UserId == currentUser.Id && e.IsCurrent == true).ToListAsync();
                lsbCurrentTasks.DataSource = null;
                lsbCurrentTasks.DisplayMember = nameof(MyTask.Name);
                lsbCurrentTasks.ValueMember = "Id";
                lsbCurrentTasks.DataSource = currentTasks;
            }
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (m >= 0)
                {
                    if (s == 0)
                    {
                        s = 59;
                        m -= 1;
                    }
                    else
                        s -= 1;
                }

                if (m == 0 && s == 0)
                {
                    timer.Stop();
                    btnStart.Text = "Start";
                    player.Play();
                    isRunning = false;
                }

                if (m < 0)
                {
                    timer.Stop();
                    m = 0; s = 0;
                    lblTimer.Text = "00:00";
                    btnStart.Text = "Start";
                }

                if (aloneProgressBar1.Value != m * 60 + s)
                    aloneProgressBar1.Value++;

                lblTimer.Text = m.ToString("00") + ":" + s.ToString("00");
            }));
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to switch?";
            string title = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {

                m = currentSetings.PomodoroTime;
                s = 0;

                aloneProgressBar1.Maximum = m * 60 + s;

                Application.DoEvents();
            }
            currentAction = 1;
            btnStart.Text = "Start";
            player?.Stop();
            timer?.Stop();
            aloneProgressBar1.Value = 0;

            lblTimer.Text = $"{m}:00";
            this.BackColor = Color.FromArgb(215, 84, 79);

            btnReport.PrimaryColor = Color.FromArgb(221, 109, 105);
            btnReport.PrimaryColor = Color.FromArgb(221, 109, 105);
            btnSetting.PrimaryColor = Color.FromArgb(221, 109, 105);
            btnLogin.PrimaryColor = Color.FromArgb(221, 109, 105);
            groupBoxTimer.BackColor = Color.FromArgb(221, 109, 105);
            btnPomodoro.PrimaryColor = Color.FromArgb(215, 84, 79);
            btnLongBreak.PrimaryColor = Color.FromArgb(215, 84, 79);
            btnShortBreak.PrimaryColor = Color.FromArgb(215, 84, 79);
            btnStart.TextColor = Color.Maroon;
            gpbListPlanned.BackGColor = Color.FromArgb(221, 109, 105);
            lsbPlannedTasks.BackColor = Color.FromArgb(221, 109, 105);
            gpbCurrentTasks.BackGColor = Color.FromArgb(221, 109, 105);
            lsbCurrentTasks.BackColor = Color.FromArgb(221, 109, 105);
            btnAddTask.PrimaryColor = Color.FromArgb(189, 74, 69);
            btnAddTask.TextColor = Color.FromArgb(221, 109, 105);

            aloneProgressBar1.BackColor = Color.Maroon;
            aloneProgressBar1.BorderColor = Color.Maroon;


        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to switch?";
            string title = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                m = currentSetings.LongBreakTime;
                s = 0;
                aloneProgressBar1.Maximum = m * 60 + s;
                Application.DoEvents();
            }
            currentAction = 2;
            btnStart.Text = "Start";
            player?.Stop();
            timer?.Stop();
            aloneProgressBar1.Value = 0;

            lblTimer.Text = $"{m}:00";
            this.BackColor = Color.FromArgb(69, 124, 163);

            btnReport.PrimaryColor = Color.FromArgb(85, 153, 201);
            btnSetting.PrimaryColor = Color.FromArgb(85, 153, 201);
            btnLogin.PrimaryColor = Color.FromArgb(85, 153, 201);
            groupBoxTimer.BackColor = Color.FromArgb(85, 153, 201);
            btnPomodoro.PrimaryColor = Color.FromArgb(69, 124, 163);
            btnLongBreak.PrimaryColor = Color.FromArgb(69, 124, 163);
            btnShortBreak.PrimaryColor = Color.FromArgb(69, 124, 163);
            btnStart.TextColor = Color.FromArgb(45, 81, 107);
            gpbListPlanned.BackGColor = Color.FromArgb(85, 153, 201);
            lsbPlannedTasks.BackColor = Color.FromArgb(85, 153, 201);
            gpbCurrentTasks.BackGColor = Color.FromArgb(85, 153, 201);
            lsbCurrentTasks.BackColor = Color.FromArgb(85, 153, 201);
            btnAddTask.PrimaryColor = Color.FromArgb(45, 81, 107);
            btnAddTask.TextColor = Color.FromArgb(85, 153, 201);

            aloneProgressBar1.BackColor = Color.FromArgb(45, 81, 107);
            aloneProgressBar1.BorderColor = Color.FromArgb(45, 81, 107);


        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to switch?";
            string title = "Close window";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                m = currentSetings.ShortBreakTime;
                s = 0;
                aloneProgressBar1.Maximum = m * 60 + s;
                Application.DoEvents();
            }
            currentAction = 3;
            btnStart.Text = "Start";
            player?.Stop();
            timer?.Stop();
            aloneProgressBar1.Value = 0;

            lblTimer.Text = $"{m}:00";
            this.BackColor = Color.FromArgb(76, 145, 149);

            btnReport.PrimaryColor = Color.FromArgb(95, 181, 186);
            btnSetting.PrimaryColor = Color.FromArgb(95, 181, 186);
            btnLogin.PrimaryColor = Color.FromArgb(95, 181, 186);
            groupBoxTimer.BackColor = Color.FromArgb(95, 181, 186);
            btnPomodoro.PrimaryColor = Color.FromArgb(76, 145, 149);
            btnLongBreak.PrimaryColor = Color.FromArgb(76, 145, 149);
            btnShortBreak.PrimaryColor = Color.FromArgb(76, 145, 149);
            btnStart.TextColor = Color.FromArgb(51, 97, 99);
            gpbListPlanned.BackGColor = Color.FromArgb(95, 181, 186);
            lsbPlannedTasks.BackColor = Color.FromArgb(95, 181, 186);
            gpbCurrentTasks.BackGColor = Color.FromArgb(95, 181, 186);
            lsbCurrentTasks.BackColor = Color.FromArgb(95, 181, 186);
            btnAddTask.PrimaryColor = Color.FromArgb(51, 97, 99);
            btnAddTask.TextColor = Color.FromArgb(95, 181, 186);

            aloneProgressBar1.BackColor = Color.FromArgb(51, 97, 99);
            aloneProgressBar1.BorderColor = Color.FromArgb(51, 97, 99);


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            player?.Stop();
            if (isRunning == true)
            {
                timer.Stop();
                Application.DoEvents();
                isRunning = false;
                btnStart.Text = "Start";
            }
            else
            {
                btnStart.Text = "Stop";
                timer.Start();
                isRunning = true;
            }

            if (lblTimer.Text.Contains("00:00"))
            {
                MessageBox.Show("Choose level to start!");
            }
        }
        //Timer------------------------------------------------------------------------------

        //<DataBase>----------------------------------------------------------------------------
        string ConnStr;
        DbContextOptions<MyPomodoroProjectContext> options = null!;
        void StartDB()
        {
            DbContextOptionsBuilder<MyPomodoroProjectContext> builder = new DbContextOptionsBuilder<MyPomodoroProjectContext>();
            IConfigurationBuilder bd = new ConfigurationBuilder(); //Microsoft.Extensions.Configuration NuGet


            string curdir = Directory.GetCurrentDirectory();
            string cutstr = curdir.Remove(curdir.Length - 25, 25);
            bd.SetBasePath(Directory.GetCurrentDirectory()); //Microsoft.Extensions.Configuration.Json NuGet
            bd.AddJsonFile(cutstr + @"\DataBase\appsettings.json");//Microsoft.Extensions.Configuration.Json NuGet
            //bd.AddJsonFile("DataBase/appsettings.json");//Microsoft.Extensions.Configuration.Json NuGet
            IConfigurationRoot config = bd.Build();
            ConnStr = config.GetConnectionString("sqlConnStr");
            builder.UseSqlServer(ConnStr)
                .LogTo(message => Debug.WriteLine(message));
            options = builder.Options;
        }
        async void CreateForDB()
        {
            using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                MyUser user = new MyUser { Login = "try", Password = "try", SecretAnswer = "try", SecretAsk = "try" };
                MyUser user1 = new MyUser { Login = "Log", Password = "Pas", SecretAnswer = "Ans", SecretAsk = "Ask" };
                context.Users.AddRange(user1, user);
                await context.SaveChangesAsync();
                MyTask task = new MyTask { EatPomodoros = 0, MaxPomodoros = 3, DateOfFinish = null, IsCurrent = false, IsFinished = false, Name = "CreateDB", WorkTime = 0, UserId = user.Id, User = user };
                MyTask task1 = new MyTask { EatPomodoros = 1, MaxPomodoros = 4, DateOfFinish = null, IsCurrent = true, IsFinished = false, Name = "CreateDefaultSettings", WorkTime = 25, UserId = user1.Id, User = user1 };
                context.Tasks.AddRange(task1, task);
                await context.SaveChangesAsync();
                Settings setting = new Settings { LongBreakTime = 25, ShortBreakTime = 15, PomodoroTime = 25, Music = 0, user = user, UserId = user.Id };
                Settings setting1 = new Settings { LongBreakTime = 25, ShortBreakTime = 15, PomodoroTime = 25, Music = 0, user = user1, UserId = user1.Id };
                context.PomodoroSettings.AddRange(setting, setting1);
                await context.SaveChangesAsync();
            }


        }
        async void CheckDB()
        {
            using (var connection = new SqlConnection(ConnStr))
            {
                string query = "Select * from Users";
                var b = await connection.QueryAsync<MyUser>(query);
                foreach (var item in b)
                {
                    MessageBox.Show($"{item.Login} - {item.Password}");
                }
            }
        }
        //</DataBase>----------------------------------------------------------------------------
        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            if (formReport.ShowDialog() == DialogResult.OK)
            {

            }
        }
        //<Settings>----------------------------------------------------------------------------
        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting(options, currentSetings.PomodoroTime, currentSetings.LongBreakTime, currentSetings.ShortBreakTime);
            formSetting.Owner = this;
            if (formSetting.ShowDialog() == DialogResult.OK)
            {
                using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
                {
                    currentSetings = context.PomodoroSettings.First(t => t.Id == currentSetings.Id);
                    if (currentAction == 1)
                    {
                        m = currentSetings.PomodoroTime;
                        lblTimer.Text = $"{m.ToString("00")}:00";
                    }
                    else if (currentAction == 2)
                    {
                        m = currentSetings.LongBreakTime;
                        lblTimer.Text = $"{m.ToString("00")}:00";
                    }
                    else if (currentAction == 3)
                    {
                        m = currentSetings.ShortBreakTime;
                        lblTimer.Text = $"{m}:00";// ????
                    }
                }
            }
        }
        //</Settings>----------------------------------------------------------------------------

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(options);
            if (formLogin.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private async void dungeonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int myTaskId = int.MaxValue;
            if (lsbPlannedTasks.SelectedIndex != -1)
            {
                myTaskId = GetPlannedTaskId();
            }
            else return;
            if (dungeonComboBox1.SelectedIndex == 0)
            {
                await EditeTask(myTaskId);
            }
            if (dungeonComboBox1.SelectedIndex == 1)
            {
                await DeleteTask(myTaskId);
            }
            await UpdateAllListBoxes();
        }
        private int GetPlannedTaskId() => (int)lsbPlannedTasks.SelectedValue;
        private int GetCurrentTaskId() => (int)lsbCurrentTasks.SelectedValue;

        private async void lsbPlannedTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lsbPlannedTasks.SelectedIndex != -1)
            {
                await FromPlannedToCurrent();
                await UpdateAllListBoxes();
            }
        }
        private async void lsbCurrentTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lsbCurrentTasks.SelectedIndex != -1)
            {
                await FromCurrentToPlanned();
                await UpdateAllListBoxes();
            }
        }
        private async Task FromCurrentToPlanned()
        {
            int myTaskId = GetCurrentTaskId();
            using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                MyTask? myTask = await context.Tasks.FirstOrDefaultAsync(e => e.Id == myTaskId);
                myTask!.IsCurrent = false;
                await context.SaveChangesAsync();
            }
        }
        private async Task FromPlannedToCurrent()
        {
            int myTaskId = GetPlannedTaskId();
            using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                MyTask? myTask = await context.Tasks.FirstOrDefaultAsync(e => e.Id == myTaskId);
                myTask!.IsCurrent = true;
                await context.SaveChangesAsync();
            }
        }

        private async void dungeonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int myTaskId = int.MaxValue;
            if (lsbCurrentTasks.SelectedIndex != -1)
            {
                myTaskId = GetCurrentTaskId();
            }
            else return;
            if (dungeonComboBox2.SelectedIndex == 0)
            {
                    await EditeTask(myTaskId);
            }
            if (dungeonComboBox2.SelectedIndex == 1)
            {
                    await DeleteTask(myTaskId);
            }
            if (dungeonComboBox2.SelectedIndex == 2)
            {
                await FinishTaskEarlier(myTaskId); 
            }
            await UpdateAllListBoxes();
        }

        private async Task EditeTask(int myTaskId)
        {
            using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                MyTask? myTask = await context.Tasks.FirstOrDefaultAsync(e => e.Id == myTaskId);
                FormAddTask formAddTask = new FormAddTask(myTask!);
                if (formAddTask.ShowDialog() == DialogResult.OK)
                {
                    context.Tasks.Update(myTask!);
                    await context.SaveChangesAsync();
                }
                else return;
            }
        }

        private async Task FinishTaskEarlier(int myTaskId)
        {
            using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to finish task earlier?", "Finish", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MyTask? myTask = await context.Tasks.FirstOrDefaultAsync(e => e.Id == myTaskId);
                    myTask!.IsFinished = true;
                    //В отчёте нужно сохранить время, которое потребовалось чтобы завершить задачу преждевременно.
                    context.Update(myTask);
                    await context.SaveChangesAsync();
                }
            }
        }
        private async Task DeleteTask(int myTaskId)
        {
            using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the task?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MyTask? myTask = await context.Tasks.FirstOrDefaultAsync(e => e.Id == myTaskId);
                    context.Tasks.Remove(myTask!);
                    await context.SaveChangesAsync();
                }
                else { return; }
            }
        }


        private async void btnAddTask_Click(object sender, EventArgs e)
        {
            MyTask myTask = new MyTask();
            FormAddTask formAddTask = new FormAddTask(myTask);
            if (formAddTask.ShowDialog() == DialogResult.OK)
            {
                //using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
                //{
                //    myTask.UserId = currentUser.Id;
                //    myTask.User = currentUser;       
                //    await context.Tasks.AddAsync(myTask);
                //    await context.SaveChangesAsync();
                //}
            }
        }
    }
}