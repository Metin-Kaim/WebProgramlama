using System.ComponentModel.DataAnnotations;

namespace Barinak.Models.Siniflar
{
	public class Hayvanlar
	{
		[Key]
		public int ID { get; set; }
		public string Adi { get; set; }
		public string Yas { get; set; }
		public string Cinsiyet { get; set; }
		public string FotoUrl { get; set; }
		public string Aciklama { get; set; }
		public int Turid { get; set; }
		//public virtual Turler Turlers { get; set; }
	}
}
