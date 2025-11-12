using EFCodeFirstStudent.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstStudent.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite database (works on Mac)
            optionsBuilder.UseSqlite("Data Source=StudentDB.db");
        }
    }
}
