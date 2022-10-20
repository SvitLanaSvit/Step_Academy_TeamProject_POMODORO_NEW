using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Pomodoro.DataBase.Models
{
    public class MyTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPomodoros { get; set; }
        public int EatPomodoros { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public MyUser User { get; set; } = new MyUser();
        //public bool IsCurrent { get; set; }
        //public bool IsActive { get; set; }
        //public bool IsFinished { get; set; }
        public TaskState TaskState { get; set; } = TaskState.Created;
        public DateTime? DateOfFinish { get; set; } = null;

        public int? WorkTime { get; set; } = 0;
    }
    public enum TaskState
        {
            Created,
            Active,
            Current,
            Finished
        }
}
