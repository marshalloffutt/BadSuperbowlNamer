﻿using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class converting_roman_numerals_to_numbers
    {
        [Fact]
        public void test01_converting_I_should_be_1()
        {
            var converter = new Numberizer();
            var input = "I";
            int expectedResult = 1;

            var actualResult = converter.ConvertToNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test02_converting_V_should_be_5()
        {
            var converter = new Numberizer();
            var input = "V";
            int expectedResult = 5;

            var actualResult = converter.ConvertToNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test03_converting_IX_should_be_9()
        {
            var converter = new Numberizer();
            var input = "IX";
            int expectedResult = 9;

            var actualResult = converter.ConvertToNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test04_converting_XII_should_be_12()
        {
            var converter = new Numberizer();
            var input = "XII";
            int expectedResult = 12;

            var actualResult = converter.ConvertToNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void test05_converting_XVI_should_be_16()
        {
            var converter = new Numberizer();
            var input = "XVI";
            int expectedResult = 16;

            var actualResult = converter.ConvertToNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
