using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using Pomodoro.DataBase.Context;
using Pomodoro.DataBase.Models;
using Rijndael256;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class FormLogin : Form
    {
        DbContextOptions<MyPomodoroProjectContext> options;
        MyUser user;
        string loginDocPath;

        public FormLogin(DbContextOptions<MyPomodoroProjectContext> options, string loginDocPath)
        {
            InitializeComponent();
            this.options = options;
            this.loginDocPath = loginDocPath;
            //this.user = new MyUser();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignInNewUser_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(options);
            if (formRegistration.ShowDialog() == DialogResult.OK)
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
                            if (item.Login == txtUserName.Text && item.Password == txtUserPassword.Text)
                            {
                                searchCount = 1;
                                owner.currentUser = item;
                                (string EncryptedLogin, string EncryptedPassword) encryptedLoginData = new(Rijndael.Encrypt(item.Login, "encpass", KeySize.Aes256),
                                    Rijndael.Encrypt(item.Password, "encpass", KeySize.Aes256));
                                using FileStream fs = new(loginDocPath, FileMode.Create);
                                JsonSerializerOptions jsoptions = new()
                                {
                                    IncludeFields = true
                                };
                                JsonSerializer.Serialize(fs, encryptedLoginData, jsoptions); //Local authentication

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

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword(options);
            formForgotPassword.ShowDialog();
        }
    }
}
