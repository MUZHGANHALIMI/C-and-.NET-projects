using EFCodeFirstStudent.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstStudent.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // For macOS/Linux (SQLite)
            optionsBuilder.UseSqlite("Data Source=StudentDB.db");

            // For Windows (SQL Server LocalDB), use instead:
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=StudentDB;Trusted_Connection=True;");
        }
    }
}
