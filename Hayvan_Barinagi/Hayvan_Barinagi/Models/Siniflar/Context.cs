using Microsoft.EntityFrameworkCore;

namespace HayvanBarinagi_.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresRehber> AdresRehbers { get; set; }
        public DbSet<BakimRehberi> BakimRehberis { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=HayvanBarinagi_db;Trusted_Connection=True;");
        }
    }
}
