using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class IletisimDataAccess : IIletisimDataAccess
    {
        private readonly YolcuDbContext _dbContext;
        public IletisimDataAccess(YolcuDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void ekle(Iletisim iletisim)
        {
            try
            {
                _dbContext.ıletisims.Add(iletisim);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: "+ ex.ToString());
            }
        }
    }
}
