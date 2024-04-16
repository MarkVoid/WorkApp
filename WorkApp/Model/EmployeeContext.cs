using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace WorkApp.Model
{
    public class EmployeeContext:DbContext
    {
    public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
        public EmployeeContext()
        {

        }
        public DbSet<Employee> Login { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString);

        

    }
}
