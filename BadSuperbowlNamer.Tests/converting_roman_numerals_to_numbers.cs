using System;
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
        public void converting_any_roman_numeral_should_return_the_correct_number(string input, int expectedResult)
        {
            var converter = new Numberizer();

            var actualResult = converter.ConvertToNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
