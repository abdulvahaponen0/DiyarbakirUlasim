using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hatlar
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen adı giriniz...")]
        [StringLength(10)]
        public string? Adi { get; set; }
        [Required(ErrorMessage = "Lütfen güzergah adını giriniz...")]
        [StringLength(20)]
        public string? Guzergah { get; set; }
        public int HareketSaatleriId { get; set; }
        public ICollection<HareketSaatleri>? hareketSaatleri { get; set; }
    }
}
