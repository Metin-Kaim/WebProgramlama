using System.ComponentModel.DataAnnotations;

namespace HayvanBarinagi_.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int RehberId { get; set; }
        public virtual BakimRehberi BakimRehberi { get; set; }
    }
}
