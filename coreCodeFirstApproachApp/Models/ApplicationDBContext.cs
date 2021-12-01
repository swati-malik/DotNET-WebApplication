using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachApp.Models
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=W104NV9K63; Database=DemoDB;User Id=sa;Password=Charu@1234;");
            /*optionsBuilder.UseSqlServer("server=W104NV9K63; Database=DemoDB;Integrated Security=true;");*/
        }
    }
}
