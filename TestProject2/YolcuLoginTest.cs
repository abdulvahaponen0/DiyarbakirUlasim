using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Entities;
namespace TestProject2
{
    public class YolcuLoginTest
    {
        private IYolcuLogin GetYolcuLoginWithInMemoryDb(string dbName)
        {
            var options = new DbContextOptionsBuilder<YolcuDbContext>()
                 .UseInMemoryDatabase(dbName).Options;
            var context = new YolcuDbContext(options);
            return new YolcuLogin(context);
        }
        [Fact]
        public void KayitOl_YeniYolcu_Eklenmeli()
        {
            var yolcuLogin = GetYolcuLoginWithInMemoryDb("TestDb1");
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
            yolcuLogin.KayitOl(yeniYolcu);
            //Assert
            var yolcular=yolcuLogin.TumYolcular();
            Assert.Single(yolcular);
            Assert.Equal("Ali", yolcular[0].Ad);
        }
    }

}