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

        [Fact]
        public void test10_converting_83_should_be_LXXXIII()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 83;
            var expectedResult = "LXXXIII";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test11_converting_97_should_be_XCVII()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 97;
            var expectedResult = "XCVII";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test11_converting_99_should_be_XCIX()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 99;
            var expectedResult = "XCIX";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test12_converting_500_should_be_D()
        {
            //Arrange -- context             -- Given
            var converter = new RomanNumeralizer();
            var input = 500;
            var expectedResult = "D";

            //Act     -- do the thing        -- When
            var actualResult = converter.ConvertToRoman(input);

            //Assert  -- checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
