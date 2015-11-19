using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicoPlacaPredictorLib.Models
{
    public class PlateNumber
    {
        public string Plate { get; private set; }
        public int LastNumber { get; private set; }

        public PlateNumber(string plateNumber)
        {
            Plate = plateNumber;

            int lastNumber;
            if (int.TryParse(plateNumber.Last().ToString(), out lastNumber))
                LastNumber = lastNumber;
            else
                throw new ArgumentException("Invalid plate number");
        }
    }
}
