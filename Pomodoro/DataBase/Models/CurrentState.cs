using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.DataBase.Models
{
    public class CurrentState
    {
        public int Id { get; set; }
        public double PomodoroTime { get; set; } = 0;
        public double LongBreakTime { get; set; } = 0;
        public double ShortBreakTime { get; set; } = 0;
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public MyUser User { get; set; } = new MyUser();
    }
}
