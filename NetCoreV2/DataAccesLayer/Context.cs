using Microsoft.EntityFrameworkCore;

namespace NetCoreV2.DataAccesLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=RAMBO3;Initial Catalog=Deneme;User ID=sa;Password=19830126;TrustServerCertificate=True");
        }
        public DbSet<Ogrenci> Ogrenci { get; set; }
    }
}
