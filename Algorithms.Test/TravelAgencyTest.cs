using Xunit;
using Codilityy;

namespace Algorithms.Test
{
    public class TravelAgencyTest
    {
        [Theory]
        //[InlineData(new int[8] { 2,1,1,3,2,1,1,3}, 3)]
        [InlineData(new int[8] { 7, 5, 2, 7, 2, 7, 4,7 }, 6)]
        public void TravelAgent(int[] A, int expectedValue)
        {
            //Arrange
            TravelAgency agent = new TravelAgency();

            //Act
            var result = agent.solution(A);
            var result2 = agent.ShortestDistance(A);

            //Assert
            Assert.Equal(expectedValue, result);
        }

    }
}
