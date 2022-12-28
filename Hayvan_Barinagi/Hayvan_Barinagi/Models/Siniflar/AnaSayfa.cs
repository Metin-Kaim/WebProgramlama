using System.ComponentModel.DataAnnotations;

namespace HayvanBarinagi_.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}
