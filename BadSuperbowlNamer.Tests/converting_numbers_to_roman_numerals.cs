using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class converting_numbers_to_roman_numerals
    {
        [Fact]
        public void test01_converting_1_should_be_I()
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
        public void test02_converting_5_should_be_V()
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
        public void test03_converting_9_should_be_IX()
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
        public void test04_converting_12_should_be_XII()
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

        [Fact]
        public void test05_converting_16_should_be_XVI()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 16;
            var expectedResult = "XVI";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test06_converting_29_should_be_XXIX()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 29;
            var expectedResult = "XXIX";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test07_converting_44_should_be_XLIV()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 44;
            var expectedResult = "XLIV";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test08_converting_45_should_be_XLV()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 45;
            var expectedResult = "XLV";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test09_converting_68_should_be_LXVIII()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 68;
            var expectedResult = "LXVIII";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
