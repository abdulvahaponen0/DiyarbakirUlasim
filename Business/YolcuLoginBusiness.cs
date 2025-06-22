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

        public bool Login(Yolcu yolcu)
        {
            return _yolcuLogin.Login(yolcu);
            //throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public Yolcu Profil(int id)
        {
            return  _yolcuLogin.Profil(id);
            //throw new NotImplementedException();
        }

        public int sessionId(string sifre, string telefonNumarasi)
        {
            return _yolcuLogin.sessionId(sifre, telefonNumarasi);   
            //throw new NotImplementedException();
        }

        public List<Yolcu> TumYolcular()
        {
            // throw new NotImplementedException();
            return _yolcuLogin.TumYolcular();
        }
    }
}
