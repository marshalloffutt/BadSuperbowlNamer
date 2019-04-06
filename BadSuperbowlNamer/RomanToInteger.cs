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
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            var totalNumber = 0;
            var previousNumber = 0;

            foreach (var letter in romanNumeral)
            {
                var currentNumber = RomanNumerals[letter];
                totalNumber += currentNumber;

                if (previousNumber != 0 && previousNumber < currentNumber)
                {
                    if (previousNumber == 1 && (currentNumber == 5 || currentNumber == 10)
                        || previousNumber == 10 && (currentNumber == 50 || currentNumber == 100)
                        || previousNumber == 100 && (currentNumber == 1000))
                    {
                        totalNumber -= 2 * previousNumber;
                    }

                    else return 0;
                }

                previousNumber = currentNumber;
            }

            return totalNumber;

        }
    }
}
