using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralizer
    {
        public string ConvertToRoman(int number)
        {
            if (number >= 500)
            {
                return "D" + ConvertToRoman(number - 500);
            }
            if (number >= 90)
            {
                return "XC" + ConvertToRoman(number - 90);
            }
            if (number >= 50)
            {
                return "L" + ConvertToRoman(number - 50);
            }
            if (number >= 40)
            {
                return "XL" + ConvertToRoman(number - 40);
            }
            if (number >= 10)
            {
                return "X" + ConvertToRoman(number - 10);
            }
            if (number >= 9)
            {
                return "IX" + ConvertToRoman(number - 9);
            }
            if (number >= 5)
            {
                return "V" + ConvertToRoman(number - 5);
            }
            if (number >= 4)
            {
                return "IV" + ConvertToRoman(number - 4);
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
