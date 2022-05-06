using StackImplementation;
using Xunit;

namespace Algorithms.Test
{
    public class AlgoExpectRecursionTest
    {
        [Fact]
        public void GetFactorialTest()
        {
            //Act
           // AlgoExpertSearch fact = new AlgoExpertSearch();

            //Arrange
            var result = AlgoExpertRecursion.Factorial(5);

            //Assert
            Assert.Equal(120, result);
        }
    }
}
