using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HareketSaatleri
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen hareket saatini giriniz...")]
        [DataType(DataType.Time)]
        public TimeSpan HareketSaati { get; set; }
        public int HatlarId { get; set; }
        public Hatlar? Hatlar { get; set; }
    }
}
