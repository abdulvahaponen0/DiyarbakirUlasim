using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class KayipEsya
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen adınızı ve soyadınızı giriniz.")]
        [StringLength(20)]
        public string? AdSoyad { get; set; }
        [Required(ErrorMessage ="Lütfen telefon numarasını giriniz")]
        [Phone]
        public string? TelefonNumarasi { get; set; }

        [Required(ErrorMessage ="Lütfen email adresini giriniz.")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Lütfen hat adını giriniz.")]
        [StringLength (20)]
        public string? HatAdi { get; set; }
        [Required(ErrorMessage ="Lütfen tarihi girer misiniz")]
        [DataType(DataType.Date)]   
        public DateTime? Tarih { get; set; }
        [Required(ErrorMessage ="Lütfen zamanı girer misiniz")]
        [DataType (DataType.Time)]
        public TimeSpan? Zaman { get; set; }
        [Required(ErrorMessage ="Lütfen indiğiniz durağı yazar mısınız")]
        [StringLength (20)]
        public string? IndiginizDurak { get; set; }
        [Required(ErrorMessage ="Lütfen tanım girer misiniz")]
        public string? Tanim { get; set; }
        [Required(ErrorMessage ="Lütfen not girer misiniz")]
        public string? Not { get; set; }
    }
}
