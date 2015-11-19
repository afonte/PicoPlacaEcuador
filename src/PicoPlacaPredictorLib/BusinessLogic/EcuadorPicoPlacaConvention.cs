using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PicoPlacaPredictorLib.Models;

namespace PicoPlacaPredictorLib.BusinessLogic
{
    class EcuadorPicoPlacaConvention : PicoPlacaRegionConvention
    {
        public override List<HoursInterval> GetStopIntervals()
        {
            HoursInterval morning = new HoursInterval(new TimeHour(7, 0, 0), new TimeHour(9, 30, 0));
            HoursInterval evening = new HoursInterval(new TimeHour(16, 0, 0), new TimeHour(19, 30, 0));

            return new List<HoursInterval>() { morning, evening };
        }

        public override List<Date> GetPublicHolidays()
        {
            List<Date> ecuadorPublicHolidays = new List<Date>()
            {
                new Date(1, 1),
                new Date(12, 2),
                new Date(27, 2),
                new Date(1, 5),
                new Date(24, 5),
                new Date(10, 8),
                new Date(9, 10),
                new Date(2, 11),
                new Date(3, 11),
                new Date(25, 12),
                new Date(31, 12)
            };

            return ecuadorPublicHolidays;
        }

        public override bool IsThisLawApplicableOnWeekends()
        {
            return true;
        }

        public override Dictionary<int, WeekDay> GetPlacasDayOff()
        {
            Dictionary<int, WeekDay> placasDayOff = new Dictionary<int, WeekDay>();
            placasDayOff.Add(1, WeekDay.Monday);
            placasDayOff.Add(2, WeekDay.Monday);
            placasDayOff.Add(3, WeekDay.Tuesday);
            placasDayOff.Add(4, WeekDay.Tuesday);
            placasDayOff.Add(5, WeekDay.Wednesday);
            placasDayOff.Add(6, WeekDay.Wednesday);
            placasDayOff.Add(7, WeekDay.Thursday);
            placasDayOff.Add(8, WeekDay.Thursday);
            placasDayOff.Add(9, WeekDay.Friday);
            placasDayOff.Add(0, WeekDay.Friday);

            return placasDayOff;
        }
    }
}
