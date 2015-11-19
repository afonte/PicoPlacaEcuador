using PicoPlacaPredictorLib.BusinessLogic;
using PicoPlacaPredictorLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictorLib
{
    public class PicoPlacaPredictor
    {
        public PicoPlacaRegionConvention PicoPlacaRegionConvention { get; private set; }

        public PicoPlacaPredictor(PicoPlacaRegionConvention regionConvention)
        {
            PicoPlacaRegionConvention = regionConvention;
        }

        public bool CarCanBeOnTheRoad(string plateNumber, string date, Time time)
        {
            try
            {
                Date datetime = new Date(date);
                if (IsPublicHoliday(datetime))
                    return true;

                if (TimeOutOfIntervals(time))
                    return true;

                int lastNumber = new PlateNumber(plateNumber).LastNumber;
                var placasDayOff = PicoPlacaRegionConvention.GetPlacasDayOff();
                if (placasDayOff.ContainsKey(lastNumber) && placasDayOff[lastNumber] == time.WeekDay)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private bool IsPublicHoliday(Date datetime)
        {
            foreach (var holiday in PicoPlacaRegionConvention.GetPublicHolidays())
            {
                if (datetime.Day == holiday.Day && datetime.Month == holiday.Month)
                    return true;
            }
            return false;
        }        

        private bool TimeOutOfIntervals(Time time)
        {
            foreach (var interval in PicoPlacaRegionConvention.GetStopIntervals())
            {
                if (interval.Begin.CompareTo(time.TimeHour) <= 0 && // interval.Begin <= time.TimeHour
                      interval.End.CompareTo(time.TimeHour) >= 0)   // interval.End   >= time.TimeHour
                    return false;
            }
            return true;
        }
    }
}
