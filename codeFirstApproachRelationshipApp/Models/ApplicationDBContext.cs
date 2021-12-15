using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codeFirstApproachRelationshipApp.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { }
        public DbSet<User> Users { get; set; }

        public DbSet<Author>  Authors{ get; set; }   
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=W104NV9K63; Database=DellDB; Integrated Security=true;");
        }*/
    }
}
