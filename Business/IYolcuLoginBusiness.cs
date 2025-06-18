using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IYolcuLoginBusiness
    {
        public void KayitOl(Yolcu yolcu);
        public List<Yolcu> TumYolcular();
        public void Login();
        public void Logout();
    }
}
