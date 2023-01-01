using System.ComponentModel.DataAnnotations;

namespace Barinak.Models.Siniflar
{
	public class Turler
	{
		[Key]
		public int ID { get; set; }
		public string TurAd { get; set; }
		public ICollection<Hayvanlar> Hayvanlars { get; set; }
	}
}
