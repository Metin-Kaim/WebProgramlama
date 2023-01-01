using System.ComponentModel.DataAnnotations;

namespace Barinak.Models.Siniflar
{
	public class Turler
	{
		[Key]
		public int ID { get; set; }
		public string TurAd { get; set; }
		//public IList<Hayvanlar> Hayvanlars { get; set; }
	}
}
