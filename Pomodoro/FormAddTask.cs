using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pomodoro.DataBase.Models;

namespace Pomodoro
{
    public partial class FormAddTask : Form
    {
        MyTask myTask;
        public FormAddTask(MyTask myTask)
        {
            InitializeComponent();
            this.myTask = myTask;
        }

        private void FormAddTask_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(myTask.Name))
                Initialize(myTask);
        }

        private void btnOKAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
                myTask.Name = txtTask.Text;
            if (nudEstPomodoros.Value != 0)
                myTask.MaxPomodoros = nudEstPomodoros.Value;
            else
            {
                MessageBox.Show("Please provide correct data!");
                return;
            }
            myTask.EatPomodoros = 0;
            myTask.DateOfFinish = null;
            myTask.IsCurrent = false;
            myTask.IsFinished = false;
            DialogResult = DialogResult.OK;
        }
        private void Initialize(MyTask myTask)
        {
            txtTask.Text = myTask.Name;
            nudEstPomodoros.Value = myTask.EatPomodoros;
        }

        private void btnCancelAddTask_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

    }
}
