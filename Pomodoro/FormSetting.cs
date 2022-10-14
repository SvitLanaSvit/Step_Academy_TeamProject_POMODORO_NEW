using Microsoft.EntityFrameworkCore;
using Pomodoro.DataBase.Context;
using Pomodoro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class FormSetting : Form
    {
        DbContextOptions<MyPomodoroProjectContext> options;
        public FormSetting(DbContextOptions<MyPomodoroProjectContext> options, int pomodoroTime, int longBreakTime, int shortBreakTime)
        {
            InitializeComponent();
            this.options = options;
            nudLongBreak.Value = longBreakTime;
            nudPomodoro.Value = pomodoroTime;
            nudShortBreak.Value = shortBreakTime;
        }
        
        private async void btnOkSetting_Click(object sender, EventArgs e)
        {
            FormMain formMain = (FormMain)this.Owner;
            using(MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                try
                {
                    if (nudLongBreak.Value == 0 || nudPomodoro.Value == 0 || nudShortBreak.Value == 0)
                        throw new Exception("Values must be greater than 0!");
                    else
                    {
                        Settings settings = context.PomodoroSettings.First(t => t.Id == formMain.currentSetings.Id);
                        settings.PomodoroTime = nudPomodoro.Value;
                        settings.LongBreakTime = nudLongBreak.Value;
                        settings.ShortBreakTime = nudShortBreak.Value;
                        settings.Music = musicComboBox.SelectedIndex;
                        await context.SaveChangesAsync();
                        this.DialogResult = DialogResult.OK;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnCancelSetting_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
