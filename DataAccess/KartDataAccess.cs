using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class KartDataAccess : IKartDataAccess
    {
        private readonly YolcuDbContext _context;
        public KartDataAccess(YolcuDbContext context)
        {
            _context = context;
        }

        public Yolcu kartDetay(int yolcuSessionID)
        {
            
            try
            {
                var yolcu=_context.yolcus.FirstOrDefault(x=>x.Id==yolcuSessionID);
                if (yolcu != null)
                {
                    return yolcu;
                }
                else {
                    throw new Exception("Yolcu bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:"+ex.ToString());   
                throw;
            }
        }
    }
}
