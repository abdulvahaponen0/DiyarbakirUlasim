using Business;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestProject2
{
    public class YolcuLoginBusinessTest
    {
        private IYolcuLoginBusiness yolcuLoginBusiness;
        private YolcuDbContext _yolcuDbContext;
        private void SetUpInMemory()
        {
            var options=new DbContextOptionsBuilder<YolcuDbContext>().UseInMemoryDatabase(databaseName:Guid.NewGuid().ToString()).Options;
            _yolcuDbContext = new YolcuDbContext(options);
            var repository=new YolcuLogin(_yolcuDbContext);
            yolcuLoginBusiness = new YolcuLoginBusiness(repository);    
        }
        [Fact]
        public void Kayit_Ol_Yeni_Yolcu_Eklenmeli()
        {
            SetUpInMemory();
            var yeniYolcu = new Yolcu
            {
                Ad = "Ali",
                SoyAd = "Önen",
                Adres = "Şeyh Şamil"
           ,
                Bakiye = 10,
                KullanıcıKodu = 104,
                EMail = "tercalnn@gmail.com",
                Sifre = "vsssdd",
                TelefonNumarasi = 55380536
            };
            yolcuLoginBusiness.KayitOl(yeniYolcu);
            var all = yolcuLoginBusiness.TumYolcular();
            Assert.Single(all);
            Assert.Equal("Ali", all[0].Ad);
        }
    }
}
