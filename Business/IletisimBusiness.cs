using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class IletisimBusiness : IIletisimBusiness
    {
        private readonly IIletisimDataAccess _dataAccess;
        public IletisimBusiness(IIletisimDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void ekle(Iletisim ıletisim)
        {
           _dataAccess.ekle(ıletisim);
        }
    }
}
