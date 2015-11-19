using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictorLib.Models
{
    public class HoursInterval
    {
        public TimeHour Begin { get; private set; }
        public TimeHour End { get; private set; }

        public HoursInterval(TimeHour begin, TimeHour end)
        {
            Begin = begin;
            End = end;
        }
    }
}
