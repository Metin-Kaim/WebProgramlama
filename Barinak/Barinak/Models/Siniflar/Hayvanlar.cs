using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
		[ForeignKey("Turid")]
		public virtual Turler Turler { get; set; }
	}
}
