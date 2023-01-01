using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barinak.Models.Siniflar
{
	public class Yorumlar
	{
		[Key]
		public int ID { get; set; }
		public string KullaniciAdi { get; set; }
		public string Mail { get; set; }
		public string Yorum { get; set; }
		public int Rehberid { get; set; }
        [ForeignKey("Rehberid")]
        public virtual Rehber Rehber { get; set; }
	}
}
