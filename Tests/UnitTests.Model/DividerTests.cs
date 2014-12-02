using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestBuy.TechnicalProbe.FizzBuzz.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestBuy.TechnicalProbe.FizzBuzz.Model.Tests
{
    [TestClass()]
    public class DividerTests
    {
        [TestMethod()]
        public void DividerTestAssertFail()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTestAssertFail()
        {
            Assert.Fail();
        }
    
        [TestMethod()]
        public void DividerTestNotImplementedException()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void DivideTestNotImplementedException()
        {
            throw new NotImplementedException();
        }
    }
}
