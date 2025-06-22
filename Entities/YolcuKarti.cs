using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class YolcuKarti
    {
        public int Id { get; set; }
        public int? Bakiye { get; set; }
        public int? BekleyenBakiye { get; set; }
        public string? KartAdi { get; set; } = "TamKart";
    }
}
