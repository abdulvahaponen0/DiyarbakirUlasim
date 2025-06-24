using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Iletisim
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen adınızı ve soyadınızı girer misiniz")]
        [StringLength(30)]
        public string? AdSoyad { get; set; }
        [Required(ErrorMessage ="Lütfen email adresiniz girer misiniz")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Lütfen telefon numaranızı girer misiniz")]
        [Phone]
        public string? TelefonNumarasi { get; set; }
        [Required(ErrorMessage ="Lütfen yorumunuzu yazar mısınız")]
        [StringLength(250)]
        public string? Yorum { get; set; }
        public int? YolcuId { get; set; }
        public Yolcu? Yolcu { get; set; }
    }
}
