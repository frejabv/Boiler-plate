using System;
using Xunit;

namespace programFolder.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void divisibleBy4True()
        {
            //arrange
            //I want to get access to the output?

            //act
            //I run the method with a number divisible by four and save the result
            var result = Program.IsLeapYear(8);

            //assert
            //I assert that the input is divisible by four and the method gives the correct output
            Assert.True(result);
        }

        [Fact]
        public void divisibleBy4And100()
        {
            //arrange
            //act
            var result1 = Program.IsLeapYear(200);
            //var result2 = Program.IsLeapYear();
            //assert
            Assert.False(result1);
            //Assert.False(result2);
        }
    }
}
