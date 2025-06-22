using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class KrediKArtiIslemleriBusiness : IKrediKArtiIslemleriBusiness
    {
        public IKrediKartiIslemleri _krediKartiIslemleri;

        public KrediKArtiIslemleriBusiness(IKrediKartiIslemleri krediKartiIslemleri)
        {
                _krediKartiIslemleri=krediKartiIslemleri;
        }
        public void BakiyeEkle(KrediKarti krediKarti)
        {
            _krediKartiIslemleri.BakiyeEkle(krediKarti);
            //throw new NotImplementedException();
        }
    }
}
