using Microsoft.EntityFrameworkCore;
using WebAPI.Users.Models;

namespace WebAPI.Users.Repository
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=base.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Guid);
            base.OnModelCreating(modelBuilder);
        }
    }
}
