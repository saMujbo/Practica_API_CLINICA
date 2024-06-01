using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Services.MyDbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Medicfile> MedicFiles { get; set;}
    }
    
}
