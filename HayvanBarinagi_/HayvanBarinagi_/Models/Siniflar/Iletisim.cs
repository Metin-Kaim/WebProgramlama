using System.ComponentModel.DataAnnotations;

namespace HayvanBarinagi_.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}
