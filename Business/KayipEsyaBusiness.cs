using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class KayipEsyaBusiness : IKayipEsyaBusiness
    {
        private readonly IKayipEsyaDataAccess _kayipEsyaDataAccess;
        public KayipEsyaBusiness(IKayipEsyaDataAccess kayipEsyaDataAccess)
        {
            _kayipEsyaDataAccess = kayipEsyaDataAccess;
        }
        public void ekle(KayipEsya kayipEsya)
        {
            _kayipEsyaDataAccess.Ekle(kayipEsya);
        }
    }
}
