using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class YolcuLogin : IYolcuLogin
    {
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
            //_context.yolcus.Add(yolcu);
            //_context.SaveChanges();
            //throw new NotImplementedException();
        }

        public List<Yolcu> TumYolcular()
        {
            return _context.yolcus.ToList();
        }
        public void Login()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
