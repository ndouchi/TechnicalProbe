using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestBuy.TechnicalProbe.FizzBuzz.Common.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BestBuy.TechnicalProbe.FizzBuzz.Common.Utility.Tests
{
    [TestClass()]
    public class DisplayTests
    {
        [TestMethod()]
        public void RecordToFileAssertFailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisplayMessageOnConsoleAssertFailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RecordToFileNotImplementedExceptionTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void DisplayMessageOnConsoleNotImplementedExceptionTest()
        {
            throw new NotImplementedException();
        }
    }
}
