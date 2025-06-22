using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IYolcuLogin
    {
        public void KayitOl(Yolcu yolcu);
        public List<Yolcu> TumYolcular();
        public bool Login(Yolcu yolcu);
        public void Logout();
        public int sessionId(string sifre,string telefonNumarasi);
        public Yolcu Profil(int id);
    }
}
