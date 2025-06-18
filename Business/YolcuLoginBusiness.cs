using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class YolcuLoginBusiness : IYolcuLoginBusiness
    {
        private readonly IYolcuLogin _yolcuLogin;
        public YolcuLoginBusiness(IYolcuLogin yolcuLogin)
        {
         _yolcuLogin = yolcuLogin;       
        }
        public void KayitOl(Yolcu yolcu)
        {
           _yolcuLogin.KayitOl(yolcu);
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public List<Yolcu> TumYolcular()
        {
            // throw new NotImplementedException();
            return _yolcuLogin.TumYolcular();
        }
    }
}
