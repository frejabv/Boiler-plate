using System;
using Xunit;
using System.IO;

namespace programFolder.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4,true)]
        [InlineData(8,true)]
        [InlineData(200,false)]
        [InlineData(1600,true)]
        [InlineData(1700,false)]
        public void generalLeapYearValidity(int year, bool value) {
            var result = Program.IsLeapYear(year);
            Assert.Equal(value, result);
        }


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
            //assert
            Assert.False(result1);
        }

        [Fact]
        public void divisibleBy400()
        {
            //arrange
            //act
            var result = Program.IsLeapYear(400);
            //assert
            Assert.True(result);
        }

        [Fact]
        public void printsYayOnLeapYear() 
        {
            //arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var input = new StringReader("1600");
            Console.SetIn(input);

            //act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString();

            //assert
            Console.WriteLine(output);
            //todo pls fix
            var array = output.Split("\n");
            output = array[1];
            Assert.Equal("yay",output); //ordn det der med new line som han også havde i test til forelæsningen
        }

        [Theory]
        [InlineData("1600", "yay")]
        [InlineData("1705", "nay")]
        public void printsYayOrNay(string inputYear, string expectedPrint) 
        {
            //arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var input = new StringReader(inputYear);
            Console.SetIn(input);

            //act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString();

            //assert
            Console.WriteLine(output);
            var array = output.Split("\n");
            output = array[1];
            Assert.Equal(expectedPrint,output); 
        }
    }
}
