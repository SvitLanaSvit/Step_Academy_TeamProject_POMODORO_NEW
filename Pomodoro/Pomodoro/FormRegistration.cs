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
    public partial class FormRegistration : Form
    {
        MyUser registerMyUser;
        Settings settings;
        DbContextOptions<MyPomodoroProjectContext> options;
        public FormRegistration(DbContextOptions<MyPomodoroProjectContext> options)
        {
            InitializeComponent();
            registerMyUser = new MyUser();
            this.options = options;
            settings = new Settings { PomodoroTime = 25, LongBreakTime =15, ShortBreakTime =5, Music = 0};
        }

        private async void btnSignInNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == null || txtUserPassword.Text == null ||
                    txtSecretTask.Text == null || txtConfirmPassword.Text == null ||
                    txtAnswerSecretTask.Text == null)
                    throw new Exception("All fields must be filled!");
                else if (txtUserPassword.Text != textConfirmUserPassword.Text)
                    throw new Exception("Passwords do not match!");
                else
                {

                    using(MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
                    {
                        foreach (var item in context.Users)
                        {
                            if(txtUserName.Text == item.Login)
                            {
                                await context.SaveChangesAsync();
                                throw new Exception("A user with the same name already exists!");
                            }
                        }
                        registerMyUser.Login = txtUserName.Text;
                        registerMyUser.Password = txtUserPassword.Text;
                        registerMyUser.SecretAsk = txtSecretTask.Text;
                        registerMyUser.SecretAnswer = txtAnswerSecretTask.Text;
                        registerMyUser.settings.Add(settings);
                        context.Users.Add(registerMyUser);
                        //await context.SaveChangesAsync();
                        settings.UserId = registerMyUser.Id;
                        context.PomodoroSettings.Add(settings);
                        await context.SaveChangesAsync();
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
