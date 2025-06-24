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
    public class KayipEsyaDataAccessTest
    {
        public DbContextOptions<YolcuDbContext> UseInMemoryOptions()
        {
            return new DbContextOptionsBuilder<YolcuDbContext>().UseInMemoryDatabase("Test5").Options;    
        }
        [Fact]
        public void Kayit_Ol()
        {
            var options=UseInMemoryOptions();
            var context=new YolcuDbContext(options);
            var kayipEsya = new KayipEsya { AdSoyad="Abdulvahap Önen",TelefonNumarasi="05538053621",Email="abdulvahaponen0@gmail.com",
            HatAdi="M3",IndiginizDurak="Metropol",Tanim="KAyıp eşya",Not="Eşyyam kayboldu",Tarih=new DateTime(2025,6,24),Zaman=new TimeSpan(2,30,0)            }; 
            IKayipEsyaDataAccess kayipEsyaDataAccess=new KayipEsyaDataAccess(context);
            kayipEsyaDataAccess.Ekle(kayipEsya);
            var esyaList = context.kayipEsyas.FirstOrDefault(x => x.AdSoyad == "Abdulvahap Önen");
            Assert.NotNull(esyaList);
            Assert.Equal("Abdulvahap Önen",esyaList.AdSoyad);
            Assert.Equal("05538053621", esyaList.TelefonNumarasi);
        }
    }
}
