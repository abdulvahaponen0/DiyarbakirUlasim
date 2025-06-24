using Business;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public class KartDataAccessTest
    {
        public DbContextOptions<YolcuDbContext> CreateNewContextOptions()
        {
            return new DbContextOptionsBuilder<YolcuDbContext>().UseInMemoryDatabase("Test3").Options;
        }



        [Fact]
        public void Kart_Detayi()
        {
            var options = CreateNewContextOptions();
            int yolcuId;

            using (var context = new YolcuDbContext(options))
            {
                var yolcu = new Yolcu
                {
                    Ad = "Abdulvahap",
                    
                    SoyAd= "Yıldız",
                    EMail = "abdulvahap@example.com",
                    Sifre = "1234",TelefonNumarasi="dsdsd",Adres="asd"
                };
                context.yolcus.Add(yolcu);
                context.SaveChanges();
                yolcuId = yolcu.Id; // Otomatik atanmış ID
            }

            using (var context = new YolcuDbContext(options))
            {
                IKartDataAccess kartDataAccess = new KartDataAccess(context);
                var yolcu = kartDataAccess.kartDetay(yolcuId);

                Assert.NotNull(yolcu);
                Assert.Equal("Abdulvahap", yolcu.Ad);
                Assert.Equal("Yıldız", yolcu.SoyAd);
            }
        }


    }
}
