using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaPredictorLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictorLibTests.UnitTests
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitDateWithString_ShouldThrowException()
        {
            string date = "27/10/YY";
            Date datetime = new Date(date);
        }

        [TestMethod]
        public void InitDateWithString()
        {
            string date = "27/10/1988";
            Date datetime = new Date(date);
            Assert.AreEqual(27, datetime.Day);
            Assert.AreEqual(10, datetime.Month);
            Assert.AreEqual(1988, datetime.Year);
        }
    }
}
