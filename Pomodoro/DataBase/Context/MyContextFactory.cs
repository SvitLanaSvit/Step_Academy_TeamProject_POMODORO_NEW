using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Pomodoro.DataBase.Context
{
    public class MyContextFactory : IDesignTimeDbContextFactory<MyPomodoroProjectContext>
    {
        public MyPomodoroProjectContext CreateDbContext(string[] args)
        {
            //builder jakij stroit` nashi options
            var optionsBuilder = new DbContextOptionsBuilder<MyPomodoroProjectContext>();
            IConfigurationBuilder builder = new ConfigurationBuilder(); //Microsoft.Extensions.Configuration NuGet
            builder.SetBasePath(Directory.GetCurrentDirectory()); //Microsoft.Extensions.Configuration.Json NuGet
            //string curdir = Directory.GetCurrentDirectory();
            //string cutstr = curdir.Remove(curdir.Length - 25, 25);
            //builder.AddJsonFile(cutstr + @"\DataBase\appsettings.json");//Microsoft.Extensions.Configuration.Json NuGet
            builder.AddJsonFile("DataBase/appsettings.json");//Microsoft.Extensions.Configuration.Json NuGet
            IConfigurationRoot config = builder.Build();
            string connStr = config.GetConnectionString("sqlConnStr");
            optionsBuilder.UseSqlServer(connStr);//Microsoft.EntityFrameworkCore.SqlServer NuGet
            var options = optionsBuilder.Options;
            return new MyPomodoroProjectContext(options);
        }
    }
}
