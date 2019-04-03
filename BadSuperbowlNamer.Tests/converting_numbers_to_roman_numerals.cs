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
            var actualResult = converter.ConvertToRoman(input);

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
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_9_should_be_IX()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 9;
            var expectedResult = "IX";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_12_should_be_XII()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 12;
            var expectedResult = "XII";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
