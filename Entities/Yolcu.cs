using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Yolcu
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen isiminizi girer misiniz?")]
        [StringLength(20)]
        public string? Ad { get; set; }
        [Required(ErrorMessage ="Lütfen soyadınızı girer misiniz?")]
        [StringLength(15)]
        public string? SoyAd { get; set; }
        public int? KullanıcıKodu { get; set; }
        [Required(ErrorMessage ="Lütfen email adresiniz girer misiniz?")]
        [Display(Name ="Email adresi")]
        [EmailAddress]
        public string? EMail { get; set; }
        [Required(ErrorMessage ="Lütfen şifrnizi girer misiniz?")]
        [DataType(DataType.Password)]   
        public string? Sifre { get; set; }
        [Required(ErrorMessage ="Lütfen telefon numaranızı girer misiniz?")]
        [Display(Name ="Telefon numarası")]
        [Phone]
        public int? TelefonNumarasi { get; set; }
        [Required(ErrorMessage ="Lütfen adresinizi girer misiniz?")]
        [StringLength(30)]
        public string? Adres { get; set; }
        public int? Bakiye { get; set; }
        public ICollection<KrediKarti> KrediKartis { get; set; }
        public ICollection<GecmisBankaIslemleri> GecmisBankaIslemleris { get; set; } 
    }
}
