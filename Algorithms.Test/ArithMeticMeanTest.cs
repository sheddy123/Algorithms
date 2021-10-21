using Codilityy;
using Xunit;


namespace Algorithms.Test
{
    public class ArithMeticMeanTest
    {

        [Theory]
        [InlineData(new int[3] { 2,1,4 }, 3, 0)]
        public void AMean(int[] A, int fragment, int expectedResult)
        {

            //Arrange
            ArithmeticMean arithmeticMean = new ArithmeticMean();

            //Act
            int result1 = arithmeticMean.solution(A, fragment);
            int result2 = arithmeticMean.AMean(A, fragment);


            //Assert
            Assert.Equal(result1, expectedResult);
            Assert.Equal(result2, expectedResult);

        }
    }
}
