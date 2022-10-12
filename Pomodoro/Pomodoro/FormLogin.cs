﻿using System;
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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSignInNewUser_Click(object sender, EventArgs e)
        {
            if(new FormRegistration().ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
