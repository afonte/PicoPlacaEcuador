using PicoPlacaPredictorLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicoPlacaPredictorLib.BusinessLogic.PicoPlacaConventions
{
    public abstract class PicoPlacaRegionConvention
    {
        public abstract List<HoursInterval> GetStopIntervals();
        public abstract List<Date> GetPublicHolidays();
        public abstract Dictionary<int, WeekDay> GetPlacasDayOff();
    }
}
