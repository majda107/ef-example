using EFExample.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace EFExample.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=database.db");
        }
    }
}