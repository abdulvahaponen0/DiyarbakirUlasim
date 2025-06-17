using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class YolcuDbContext:DbContext
    {
        public YolcuDbContext(DbContextOptions<YolcuDbContext> options) :base(options) { }
        public DbSet<Yolcu> yolcus { get; set; }
        public DbSet<KrediKarti> krediKartis { get; set; }  
        public DbSet<GecmisBankaIslemleri> gecmisBankaIslemleris { get; set; }
    }
}
