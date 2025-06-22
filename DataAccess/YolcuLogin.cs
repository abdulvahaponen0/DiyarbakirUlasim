using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class YolcuLogin : IYolcuLogin
    {
        private bool isYolcuLoggedIn = false;
        private readonly YolcuDbContext _context;
        public YolcuLogin(YolcuDbContext context)
        {
            _context = context;
        }
        //Yolcu kayıt ol işlemini yapar.
        public void KayitOl(Yolcu yolcu)
        {
            try
            {
                _context.yolcus.Add(yolcu);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
                throw ;
            }
        }

        public List<Yolcu> TumYolcular()
        {
            return _context.yolcus.ToList();
        }
        //Yolcu için giriş kontrolü yapar
        public bool Login(Yolcu yolcu)
        {
            var isLoggedIn=_context.yolcus.FirstOrDefault(y=>y.TelefonNumarasi==yolcu.TelefonNumarasi && y.Sifre==yolcu.Sifre);
            if (isLoggedIn != null) {
               return true;
            }
            else
            {
                return false;
            }
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public int sessionId(string sifre, string telefonNumarasi)
        {
            var yolcuVarmi=_context.yolcus.FirstOrDefault(x=>x.Sifre==sifre && x.TelefonNumarasi==telefonNumarasi);
            int id=0;
            string error="";
                if (yolcuVarmi != null)
                {
                    id = yolcuVarmi.Id;
                }
                else
                {
                    error = "Yolcu bulunamadı!";
                }
            return id;
            //throw new NotImplementedException();
        }

        public Yolcu Profil(int id)
        {
            var yolcu=_context.yolcus.FirstOrDefault(x=> x.Id==id);
            Yolcu yolcu1=new Yolcu();
            if (yolcu != null) {
                 return yolcu;
            }
            else
            {
                throw new Exception("kullanıcı bulınamadı!");
            }
        }
    }
}
