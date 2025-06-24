using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KayipEsyaDataAccess : IKayipEsyaDataAccess
    {
        private readonly YolcuDbContext _context;
        public KayipEsyaDataAccess(YolcuDbContext context)
        {
            _context = context;
        }
        public void Ekle(KayipEsya kayipEsya)
        {
            try
            {
                _context.kayipEsyas.Add(kayipEsya);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Kayıp eşya eklenemedi!");
            }
        }
    }
}
