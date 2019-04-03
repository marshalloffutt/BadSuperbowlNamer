using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class converting_numbers_to_roman_numerals
    {
        [Fact]
        public void converting_1_should_be_I()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 1;
            var expectedResult = "I";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertMyShit(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_5_should_be_V()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 5;
            var expectedResult = "V";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertMyShit(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
