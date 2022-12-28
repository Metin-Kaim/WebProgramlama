using System.ComponentModel.DataAnnotations;

namespace HayvanBarinagi_.Models.Siniflar
{
    public class BakimRehberi
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string AnimalImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }

    }
}
