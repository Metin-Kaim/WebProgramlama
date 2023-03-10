using Microsoft.EntityFrameworkCore;

namespace Barinak.Models.Siniflar
{
	public class Context:DbContext
	{

		public DbSet<Admin> Admins { get; set; }
		public DbSet<Rehber> Rehbers { get; set; }
		public DbSet<Yorumlar> Yorumlars { get; set; }
		public DbSet<Hayvanlar> Hayvanlars { get; set; }
		public DbSet<Turler> Turlers { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=DB_Barinak;Trusted_Connection=True;");
		}
	}
}
