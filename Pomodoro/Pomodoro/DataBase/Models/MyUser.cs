using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.DataBase.Models
{
    public class MyUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string SecretAsk { get; set; }
        public string SecretAnswer { get; set; }
        //public List<MyTask> Tasks { get; set; } = new List<MyTask>();
        //public List<Settings> settings { get; set; } = new List<Settings>();
        public ICollection<Settings> settings { get; set; }
        public ICollection<MyTask> Tasks { get; set; }
        public MyUser()
        {
            settings = new HashSet<Settings>();
            Tasks = new HashSet<MyTask>();
        }
    }
}
