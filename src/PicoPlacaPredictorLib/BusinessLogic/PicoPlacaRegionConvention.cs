using PicoPlacaPredictorLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictorLib.BusinessLogic
{
    public abstract class PicoPlacaRegionConvention
    {
        public abstract List<HoursInterval> GetStopIntervals();
        public abstract List<Date> GetPublicHolidays();
        public abstract bool IsThisLawApplicableOnWeekends();
        public abstract Dictionary<int, WeekDay> GetPlacasDayOff();
    }
}
