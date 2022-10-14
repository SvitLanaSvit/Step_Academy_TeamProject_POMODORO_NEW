using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.DataBase.Models
{
    public class MyTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPomodoros { get; set; }
        public int EatPomodoros { get; set; }
        public int UserId { get; set; }
        public MyUser User { get; set; } = new MyUser();
        public bool IsCurrent { get; set; }
        public bool IsFinished { get; set; }
        public DateTime? DateOfFinish { get; set; } = null;

        public int? WorkTime { get; set; } = 0;

    }
}
