using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaPredictorLib;
using PicoPlacaPredictorLib.BusinessLogic;
using PicoPlacaPredictorLib.Models;

namespace PicoPlacaPredictorLibTests
{
    [TestClass]
    public class PicoPlacaPredictorTests
    {
        PicoPlacaPredictor predictor;

        [TestInitialize]
        public void TestInit()
        {
            predictor = new PicoPlacaPredictor(new EcuadorPicoPlacaConvention());
        }

        [TestMethod]
        public void CarCanBeOnTheRoadTest_PublicHoliday()
        {
            bool canBeOnTheRoad = predictor.CarCanBeOnTheRoad("AB123451", "2/11/2015", 
                                                              new Time(WeekDay.Monday, new TimeHour(8, 10, 0)));
            Assert.IsTrue(canBeOnTheRoad);
        }

        [TestMethod]
        public void CarCanBeOnTheRoadTest_TimeOutOfIntervals()
        {
            bool canBeOnTheRoad = predictor.CarCanBeOnTheRoad("AB123455", "18/11/2015",
                                                              new Time(WeekDay.Wednesday, new TimeHour(10, 10, 0)));
            Assert.IsTrue(canBeOnTheRoad);
        }

        [TestMethod]
        public void CarCanBeOnTheRoadTest_Weekend()
        {
            bool canBeOnTheRoad = predictor.CarCanBeOnTheRoad("AB123455", "22/11/2015",
                                                              new Time(WeekDay.Sunday, new TimeHour(10, 10, 0)));
            Assert.IsTrue(canBeOnTheRoad);
        }

        [TestMethod]
        public void CarCanBeOnTheRoadTest_EveningInterval()
        {
            bool canBeOnTheRoad = predictor.CarCanBeOnTheRoad("AB123452", "16/11/2015",
                                                              new Time(WeekDay.Monday, new TimeHour(17, 59, 0)));
            Assert.IsFalse(canBeOnTheRoad);
        }

        [TestMethod]
        public void CarCanBeOnTheRoadTest_MorningInterval()
        {
            bool canBeOnTheRoad = predictor.CarCanBeOnTheRoad("AB123452", "16/11/2015",
                                                              new Time(WeekDay.Monday, new TimeHour(9, 29, 59)));
            Assert.IsFalse(canBeOnTheRoad);
        }
    }
}
