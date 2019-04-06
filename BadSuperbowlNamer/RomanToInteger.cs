using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class Numberizer
    {
        public int ConvertToNumber(string romanNumeral)
        {
            Dictionary<char, int> RomanNumerals = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
            };

            var totalNumber = 0;
            var prevValue = 0;

            foreach (var letter in romanNumeral)
            {
                var currentValue = RomanNumerals[letter];
                totalNumber += currentValue;

                if (prevValue != 0 && prevValue < totalNumber)
                {
                    if (prevValue == 1)
                    {
                        totalNumber -= 2;
                    }
                    else return 0;
                }
                prevValue = totalNumber;
            }
            return totalNumber;

        }
    }
}
