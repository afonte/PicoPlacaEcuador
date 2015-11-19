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
    public class PlateNumberTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitPlateNumber_ShouldThrowException()
        {
            string plate = "AB12332323A";
            PlateNumber plateNumber = new PlateNumber(plate);
        }

        [TestMethod]
        public void InitPlateNumber()
        {
            string plate = "AB123323239";
            PlateNumber plateNumber = new PlateNumber(plate);
            Assert.AreEqual(9, plateNumber.LastNumber);
            Assert.AreEqual(plate, plateNumber.Plate);
        }
    }
}
