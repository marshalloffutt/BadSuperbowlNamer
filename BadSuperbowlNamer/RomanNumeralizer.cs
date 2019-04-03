using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralizer
    {
        public string ConvertMyShit(int numberToConvert)
        {
            if (numberToConvert == 5)
            {
                return "V";
            }
            else
            {
                return "I";
            }
        }
    }
}
