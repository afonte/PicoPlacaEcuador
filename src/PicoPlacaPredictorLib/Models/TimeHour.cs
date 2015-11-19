using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicoPlacaPredictorLib.Models
{
    public class TimeHour : IComparable<TimeHour>
    {
        public int Hour { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public TimeHour(int hour, int minutes, int seconds)
        {
            Hour = hour;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int CompareTo(TimeHour other)
        {
            if (Hour != other.Hour)
                return Hour - other.Hour;
            if (Minutes != other.Minutes)
                return Minutes - other.Minutes;
            return Seconds - other.Seconds; 
        }
    }
}
