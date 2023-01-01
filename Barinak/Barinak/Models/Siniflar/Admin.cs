using System.ComponentModel.DataAnnotations;

namespace Barinak.Models.Siniflar
{
	public class Admin
	{
		[Key]
		public int ID { get; set; }
		public string Mail { get; set; }
		public string Sifre { get; set; }
	}
}
