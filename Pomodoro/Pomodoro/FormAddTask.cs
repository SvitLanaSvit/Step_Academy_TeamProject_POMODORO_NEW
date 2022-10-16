using Pomodoro.DataBase.Models;

namespace Pomodoro
{
    public partial class FormAddTask : Form
    {
        private readonly MyTask taskToBeEdited;

        public FormAddTask(MyTask taskToBeEdited)
        {
            InitializeComponent();

            this.taskToBeEdited = taskToBeEdited;

            //the focus is initially on the cancel button, so that at startup, placeholder txtTask
            //is seen ("What are you working on?")
            btnCancelAddTask.Select();
        }

        private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnButtonOkClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                ShowError("Task name is required");
                return;
            }

            taskToBeEdited.Name = txtTask.Text;
            taskToBeEdited.MaxPomodoros = (int) nudEstPomodoros.Value;
            DialogResult = DialogResult.OK;
        }

        private void OnCancelButtonClick(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
