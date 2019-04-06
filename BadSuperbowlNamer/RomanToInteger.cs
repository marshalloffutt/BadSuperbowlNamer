using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class Numberizer
    {
        public int ConvertToNumber(string romanNumeral)
        {
            var number = 0;
            if (romanNumeral == "I")
            {
                number = 1;
            }
            return number;

        }
    }
}
