using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomodoro.DataBase.Models;
namespace Pomodoro.DataBase.Context
{
    public class MyPomodoroProjectContext : DbContext
    {
        public DbSet<MyUser> Users { get; set; } = null!;
        public DbSet<MyTask> Tasks { get; set; } = null!;
        public DbSet<Settings> PomodoroSettings { get; set; } = null!;

        public MyPomodoroProjectContext(DbContextOptions<MyPomodoroProjectContext> options) : base(options) { }
    }
}
