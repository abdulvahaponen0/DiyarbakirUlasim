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
    public class IletisimDataAccessTest
    {
        public DbContextOptions<YolcuDbContext> UseInMemoryOption()
        {
            return new DbContextOptionsBuilder<YolcuDbContext>().UseInMemoryDatabase("Test6").Options;
        }
        [Fact]
        public void Ekle_Testi()
        {
            var options=UseInMemoryOption();
            var context=new YolcuDbContext(options);
            IIletisimDataAccess ıletisimDataAccess=new IletisimDataAccess(context);
            var iletisim = new Iletisim {AdSoyad="Abdulvahap Önen",Email="tercalnn@gmail.com",TelefonNumarasi="05538053621",Yorum="İlk Yorum"};
            ıletisimDataAccess.ekle(iletisim);
            var iletisimTest = context.ıletisims.FirstOrDefault();
            Assert.NotNull(iletisimTest);
            Assert.Equal("Abdulvahap Önen",iletisimTest.AdSoyad);
            Assert.Equal("05538053621",iletisimTest.TelefonNumarasi);
        }
    }
}
