using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaPredictorLib.Models;

namespace PicoPlacaPredictorLibTests.UnitTests
{
    [TestClass]
    public class TimeHourTests
    {
        [TestMethod]
        public void CompareToTest_LowerInHours()
        {
            TimeHour hour1 = new TimeHour(10, 0, 0);
            TimeHour hour2 = new TimeHour(16, 0, 0);

            int comparison = hour1.CompareTo(hour2);
            Assert.AreEqual(-6, comparison);
        }

        [TestMethod]
        public void CompareToTest_HigerInHours()
        {
            TimeHour hour1 = new TimeHour(20, 0, 0);
            TimeHour hour2 = new TimeHour(16, 0, 0);

            int comparison = hour1.CompareTo(hour2);
            Assert.AreEqual(4, comparison);
        }

        [TestMethod]
        public void CompareToTest_LowerInMinutes()
        {
            TimeHour hour1 = new TimeHour(10, 10, 0);
            TimeHour hour2 = new TimeHour(10, 50, 0);

            int comparison = hour1.CompareTo(hour2);
            Assert.AreEqual(-40, comparison);
        }

        [TestMethod]
        public void CompareToTest_HigerInMinutes()
        {
            TimeHour hour1 = new TimeHour(10, 30, 0);
            TimeHour hour2 = new TimeHour(10, 0, 0);

            int comparison = hour1.CompareTo(hour2);
            Assert.AreEqual(30, comparison);
        }

        [TestMethod]
        public void CompareToTest_Equals()
        {
            TimeHour hour1 = new TimeHour(10, 25, 15);
            TimeHour hour2 = new TimeHour(10, 25, 15);

            int comparison = hour1.CompareTo(hour2);
            Assert.AreEqual(0, comparison);
        }
    }
}
