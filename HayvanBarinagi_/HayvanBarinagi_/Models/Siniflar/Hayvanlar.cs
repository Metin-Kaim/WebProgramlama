using System.ComponentModel.DataAnnotations;

namespace HayvanBarinagi_.Models.Siniflar
{
    public class Hayvanlar
    {
        [Key]
        public int Id { get; set; }
        public string Cins { get; set; }
        public string Adi { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }
        public string Aciklama { get; set; }
    }
}
