using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KrediKartiIslemleri : IKrediKartiIslemleri
    {
        YolcuDbContext _context;
        public KrediKartiIslemleri(YolcuDbContext context)
        {
                _context = context;
        }
        public void BakiyeEkle(KrediKarti krediKarti)
        {
            try
            {
                _context.krediKartis.Add(krediKarti);
                _context.SaveChanges();
                var yolcu = _context.yolcus.FirstOrDefault(y => y.Id == krediKarti.YolcuId);
                if (yolcu != null && krediKarti.Tutar.HasValue)
                {
                    // 3. Bakiye null olabilir, 0 olarak kabul edip ekle
                    yolcu.Bakiye = (yolcu.Bakiye ?? 0) + krediKarti.Tutar.Value;

                    // 4. Değişikliği kaydet
                    _context.SaveChanges();
                }
                /*if (yolcu != null && krediKarti.Tutar != null) {
                    yolcu.Bakiye += krediKarti.Tutar;
                    _context.SaveChanges();
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
                throw;
            }
        }
    }
}
