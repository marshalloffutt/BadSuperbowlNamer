﻿using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class converting_roman_numerals_to_numbers
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("IX", 9)]
        [InlineData("XII", 12)]
        [InlineData("XVI", 16)]
        [InlineData("XXIX", 29)]
        [InlineData("XLIV", 44)]
        [InlineData("XLV", 45)]
        [InlineData("LXVIII", 68)]
        [InlineData("LXXXIII", 83)]
        [InlineData("XCVII", 97)]
        [InlineData("XCIX", 99)]
        [InlineData("D", 500)]
        [InlineData("DI", 501)]
        [InlineData("DCXLIX", 649)]
        [InlineData("DCCXCVIII", 798)]
        [InlineData("DCCCXCI", 891)]
        [InlineData("M", 1000)]
        [InlineData("MIV", 1004)]
        [InlineData("MVI", 1006)]
        [InlineData("MXXIII", 1023)]
        [InlineData("MMXIV", 2014)]
        [InlineData("MMMCMXCIX", 3999)]
        public void converting_any_roman_numeral_should_return_the_correct_number(string input, int expectedResult)
        {
            var converter = new Numberizer();

            var actualResult = converter.ConvertToNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
