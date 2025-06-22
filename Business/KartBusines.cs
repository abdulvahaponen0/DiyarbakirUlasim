using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class KartBusines : IKartBusiness
    {
        private readonly IKartDataAccess _kartDataAccess;
        public KartBusines(IKartDataAccess kartDataAccess) {
          _kartDataAccess = kartDataAccess;
        }
        public Yolcu kartDetay(int yolcuSessionID)
        {
            return _kartDataAccess.kartDetay(yolcuSessionID);
        }
    }
}
