using System.ComponentModel.DataAnnotations;

namespace Barinak.Models.Siniflar
{
	public class Rehber
	{
		[Key]
		public int ID { get; set; }
		public string Baslik { get; set; }
		public DateTime Tarih { get; set; }
		public string Aciklama { get; set; }
		public string RehberImage { get; set; }
		public ICollection<Yorumlar> Yorumlars { get; set; }
	}
}
