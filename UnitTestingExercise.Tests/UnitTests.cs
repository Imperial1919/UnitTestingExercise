
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(5, 10, 100, 115)]
        [InlineData(10,10, 10, 30)]
        public void Addition(int num1, int num2, int num3, int expected1)
        {
            //Arrange
            var arrange1 = new UnitTestMethods();
            //Act
            var actual1 = arrange1.Addition(num1, num2, num3);
            //Assert
            Assert.Equal(expected1,actual1);
        }

        [Theory]
        [InlineData(10000, 5000, 5000)]
        [InlineData(36,360, -324)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var arrange2 = new UnitTestMethods();
            //Act
            var actual2 = arrange2.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual2);
        }

        [Theory]
        [InlineData(6,6,36)]
        [InlineData(10,10,100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var arrange3 = new UnitTestMethods();
            //Act
            var actual3 = arrange3.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual3);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(100,10,10)]
        public void Divide(int num1, int num2, int expected)
        {
               //arrange
            var arrange3 = new UnitTestMethods();
            //act
            var actual3 = arrange3.Divide(num1, num2);
            //assert
            Assert.Equal(expected, actual3);
        }

        [Fact]
        public void Hello()
        {
            //Arrange
            var arrange = new UnitTestMethods();
            //Act
            var actual = arrange.Hello();

            //Assert
            Assert.Equal("Bryce",actual);
        }

        [Fact]
        public void Goodbye()
        {
            //Arrange
        var arrange = new UnitTestMethods();
            //Act
        var actual = arrange.Goodbye();
            //Assert
            Assert.Equal("GoodbyeFriend.", actual);

        }
    }
}
