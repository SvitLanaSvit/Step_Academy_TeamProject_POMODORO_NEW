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
        public DbSet<CurrentState> CurrentStates { get; set; } = null!;
        public MyPomodoroProjectContext(DbContextOptions<MyPomodoroProjectContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<MyTask>()
                .Property(t => t.TaskState)
                .HasConversion(
                v => v.ToString(),
            v => (TaskState)Enum.Parse(typeof(TaskState), v));

        }
    }
}
