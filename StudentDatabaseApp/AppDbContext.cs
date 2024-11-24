using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace StudentDatabaseApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } // Represents the Students table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string for the database
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentDb;Trusted_Connection=True;");
        }
    }
}
