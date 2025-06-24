using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HatlarRepository : IHatlarRepository
    {
        private readonly YolcuDbContext _context;
        public HatlarRepository(YolcuDbContext context) {
           _context = context;
        }
        public List<Hatlar> HatlarListele()
        {
            try
            {
                var hatlar = _context.hatlars.ToList();
                if (hatlar != null)
                {
                    return hatlar;
                }
                else
                {
                    throw new Exception("Hat bulunamadı");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: "+ex.ToString());
            }
        }
    }
}
