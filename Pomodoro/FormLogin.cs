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
    public partial class FormLogin : Form
    {
        DbContextOptions<MyPomodoroProjectContext> options;
        MyUser user;
        public FormLogin(DbContextOptions<MyPomodoroProjectContext> options)
        {
            InitializeComponent();
            this.options = options;
            //this.user = new MyUser();
        }

        private void btnSignInNewUser_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(options);
            if(formRegistration.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration completed successfully!");
            }
            //if(new FormRegistration().ShowDialog() == DialogResult.OK)
            //{
            //    this.Close();
            //}
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain owner = (FormMain)this.Owner;
                if (txtUserName.Text == null || txtUserPassword.Text == null)
                    throw new Exception("All fields must be filled!");
                else
                {
                    int searchCount = -1;
                    using (MyPomodoroProjectContext context = new MyPomodoroProjectContext(options))
                    {
                        
                        await context.Users.LoadAsync();
                        foreach (var item in context.Users)
                        {
                            if(item.Login == txtUserName.Text && item.Password == txtUserPassword.Text)
                            {
                                searchCount = 1;
                                owner.currentUser = item;
                                break;
                            }
                        }
                    }
                    if (searchCount == -1)
                        throw new Exception("Wrong login or password!");
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
