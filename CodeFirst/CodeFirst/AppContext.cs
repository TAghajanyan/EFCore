using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=desktop-1e9tt7s\\sqlexpress2017; Database=TestDB; Trusted_Connection=True");
        }
    }
}
