using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralizer
    {
        public string ConvertToRoman(int number)
        {
            if (number >= 5)
            {
                return "V" + ConvertToRoman(number - 5);
            }
            if (number >= 1)
            {
                return "I" + ConvertToRoman(number - 1);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
