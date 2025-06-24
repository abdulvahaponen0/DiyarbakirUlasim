using Business;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace TestProject2
{
    public class HatlarRepositoryTest
    {
        public DbContextOptions<YolcuDbContext> CreateOptionsInMemory() {
            return new DbContextOptionsBuilder<YolcuDbContext>().UseInMemoryDatabase("Test4").Options;
        }
        [Fact]
        public void Hatlar_Listele_Test()
        {
            using (var context = new YolcuDbContext(CreateOptionsInMemory()))
            {
                var hatlar = new Hatlar { Adi = "M3", Guzergah = "Metropol-Araştırma" };
                context.hatlars.Add(hatlar);
                context.SaveChanges();
            }
            using(var context=new YolcuDbContext(CreateOptionsInMemory()))
            {
                IHatlarRepository hatlarRepository=new HatlarRepository(context);
                var hatlar= hatlarRepository.HatlarListele();
                Assert.NotNull(hatlar);
                Assert.Single(hatlar);
                Assert.Equal("M3", hatlar[0].Adi);
                Assert.Equal("Metropol-Araştırma", hatlar[0].Guzergah);
            }
        }
    }
}
