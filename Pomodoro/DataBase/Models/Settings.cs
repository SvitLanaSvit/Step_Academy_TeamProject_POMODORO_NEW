using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.DataBase.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public int PomodoroTime { get; set; }
        public int LongBreakTime { get; set; }
        public int ShortBreakTime { get; set; }
        public int Music { get; set; }
        public int UserId { get; set; }
        public MyUser user { get; set; } = new MyUser();
        
    }
}
