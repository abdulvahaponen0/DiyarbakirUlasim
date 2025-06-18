using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Entities;
using DataAccess;

namespace Business.Tests
{
    [TestClass()]
    public class YolcuLoginBusinessTests
    {
        private IYolcuLoginBusiness _business;
        private YolcuDbContext _yolcuDbContext;
        private void SetUpInMemory()
        {
           // var options=new DbContextOptionsBuilder<YolcuDbContext>()
        }
        [TestMethod()]
        public void KayitOlTest()
        {
            Assert.Fail();
        }
    }
}