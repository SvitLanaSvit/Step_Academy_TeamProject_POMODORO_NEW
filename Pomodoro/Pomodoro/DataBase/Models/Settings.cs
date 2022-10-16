using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
       public MyUser User { get; set; } = new MyUser();
        
    }
}
