using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictorLib.Models
{
    public class TimeHour
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
    }
}
