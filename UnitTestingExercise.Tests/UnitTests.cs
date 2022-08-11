using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(3,6,4,13)]
        [InlineData(-8,-2,15,5)]
        [InlineData(2,23,-47, -22)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var addTest = new UnitTestMethods();
            //Act
            var actual = addTest.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,1)]
        [InlineData(15,8,7)]
        [InlineData(22,-70,92)]
        [InlineData(-7,8,-15)]
        [InlineData(76,222,-146)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subtractTest = new UnitTestMethods();
            //Act
            var actual = subtractTest.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,4,12)]
        [InlineData(5,-5,-25)]
        [InlineData(17,76,1292)]
        [InlineData(-1,0,0)]
        [InlineData(-16,-16,256)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiplyTest = new UnitTestMethods();
            //Act
            var actual = multiplyTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,1)]
        [InlineData(16,2,8)]
        [InlineData(-28,7,-4)]
        [InlineData(-30,-5,6)]
        [InlineData(17,0,0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divideTest = new UnitTestMethods();
            //Act
            var actual = divideTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void HelloWorldTest()
        {
            //Arrange
            var helloTest = new UnitTestMethods();
            //Act
            var actual = "Hello World!";
            //Assert
            Assert.Equal("Hello World!", actual);
        }

        [Fact]
        public void ReturnFiveTest()
        {
            //Arrange
            var fiveTest = new UnitTestMethods();
            //Act
            var actual = 5;
            //Assert
            Assert.Equal(5, actual);
        }
    }
}
