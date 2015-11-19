using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicoPlacaPredictorLib.Models
{
    public class Time
    {
        public WeekDay WeekDay { get; private set; }
        public TimeHour TimeHour { get; private set; }

        public Time(WeekDay weekDay, TimeHour timeHour)
        {
            WeekDay = weekDay;
            TimeHour = timeHour;
        }
    }
}
