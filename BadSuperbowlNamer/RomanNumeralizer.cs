using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralizer
    {
        public string ConvertToRoman(int number)
        {
            Dictionary<int, string> RomanNumeralsDictionary = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX"},
                { 5, "V" },
                { 4, "IV" },
                { 1, "I"}
            };

            var RomanNumeral = new StringBuilder();

            foreach (var kvp in RomanNumeralsDictionary)
            {
                while (number >= kvp.Key)
                {
                    RomanNumeral.Append(kvp.Value);
                    number -= kvp.Key;
                }
            }
            return RomanNumeral.ToString();
        }
    }
}
