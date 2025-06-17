using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GecmisBankaIslemleri
    {
        public int Id { get; set; }
        [Display(Name ="Yolcu bakiyesi")]
        public int Bakiye { get; set; }
        [Display(Name ="İşlem tarihi")]
        public DateTime Tarih { get; set; }
        [Display(Name ="Kart Numarası")]
        [DataType(DataType.CreditCard)]
        public int KartNumarasi { get; set; }
        public int? YolcuId { get; set; }
        public Yolcu? Yolcu { get; set; }
    }
}
