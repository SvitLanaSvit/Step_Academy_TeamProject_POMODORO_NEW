using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.DataBase.ViewClasses
{
    public class DetailsClass
    {
        public int WorkTime { get; set; }
        public DateTime DateOfFinish { get; set; }
        public string NameTask { get; set; } = null;
    }
}
