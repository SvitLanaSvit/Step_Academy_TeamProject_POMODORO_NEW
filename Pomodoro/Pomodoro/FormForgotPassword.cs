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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword(DbContextOptions<MyPomodoroProjectContext> options)
        {
            InitializeComponent();
            this.options = options;
        }

        DbContextOptions<MyPomodoroProjectContext> options;
        MyUser user;
        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            //btnSend.Enabled = false;
            //txtBoxSecretAnswer.Enabled = false;
            //txtBoxSecretQuestion.Enabled = false;
            gpbSecretQuestion.Enabled = false;
        }

        private async void btnChk_Click(object sender, EventArgs e)
        {
            using(MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                try
                {
                    await context.Users.LoadAsync();
                    if (txtBoxUserName.Text == null)
                        throw new Exception("Fill in the field with the username!");
                    int searchCount = -1;
                    foreach (var item in context.Users)
                    {
                        if (item.Login == txtBoxUserName.Text)
                        {
                            searchCount = 1;
                            user = item;
                        }
                            
                    }
                    if (searchCount == -1)
                        throw new Exception("User is not found!");
                    txtBoxSecretQuestion.Text = user.SecretAsk;
                    //btnSend.Enabled = true;
                    //txtBoxSecretAnswer.Enabled = true;
                    //txtBoxSecretQuestion.Enabled = true;
                    gpbSecretQuestion.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using(MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
            {
                try
                {
                    if (txtBoxSecretAnswer.Text == null)
                        throw new Exception("Fill in the field with the answer!");
                    if (txtBoxSecretAnswer.Text != user.SecretAnswer)
                        throw new Exception("The answer is not correct!");
                    else
                    {
                        MessageBox.Show($"Your current password: {user.Password}");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
