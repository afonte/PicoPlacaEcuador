using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictorLib.Models
{
    public class Date
    {
        const string INCORRECT_DATE_FORMAT_MSG = "Incorrect date format";

        public int Year { get; private set; }
        public int Month { get; private  set; }
        public int Day { get; private set; }

        public Date(int day, int month, int year) : this(day, month)
        {
            Year = year;
        }

        public Date(int day, int month)
        {
            Day = day;
            Month = month;
        }

        public Date(string date)
        {
            string[] splitDate = date.Split('/');

            int day, month, year;
            if (int.TryParse(splitDate[0], out day) &&
                int.TryParse(splitDate[1], out month) &&
                int.TryParse(splitDate[2], out year))
            {
                Day = day;
                Month = month;
                Year = year;
            }
            else
                throw new ArgumentException(INCORRECT_DATE_FORMAT_MSG);
        }
    }
}
