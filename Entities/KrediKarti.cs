using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class KrediKarti
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen isiminizi soyadınızı girer misiniz?")]
        [StringLength(30)]
        public string? KartSahibi { get; set; }
        [Required(ErrorMessage ="Lütfen 16 numaralı kart numarasını girer misiniz?")]
        [StringLength(16,ErrorMessage ="Kart numarası 16 haneli olmalıdır.")]
        [DataType(DataType.CreditCard)]
        public string? KartNumarasi  { get; set; }
        [Required(ErrorMessage ="Lütfen tarihi girer misiniz?")]
        [Display(Name ="Son kullanma tarihi")]
        [DataType(DataType.Date)]
        public  DateTime SonKullanmaTarihi { get; set; }
        [Required(ErrorMessage ="Lütfen güvenlik kodunu girer misiniz?")]
        [Range(100, 999, ErrorMessage = "Güvenlik kodu 3 haneli olmalıdır.")]
        public int GuvenlikKodu { get; set; }
        public int? Tutar { get; set; }
        public int? YolcuId { get; set; }
        public Yolcu? Yolcu { get; set; }
    }
}
