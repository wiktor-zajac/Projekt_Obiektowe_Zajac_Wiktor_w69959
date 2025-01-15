using Microsoft.EntityFrameworkCore;
using WebAPI.Pages.Models;
using WebAPI.Users.Models;

namespace WebAPI
{
    public class WebAPIContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Page> Pages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=base.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Guid);
            modelBuilder.Entity<Page>().HasKey(x => x.Guid);
            base.OnModelCreating(modelBuilder);
        }
    }
}
