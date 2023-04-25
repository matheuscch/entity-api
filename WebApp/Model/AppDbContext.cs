using Microsoft.EntityFrameworkCore;

namespace WebApp.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TempTest;Integrated Security=true");
        }
    }
}
