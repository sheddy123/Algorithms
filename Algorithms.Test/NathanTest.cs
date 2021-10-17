using Codilityy;
using Xunit;

namespace Algorithms.Test
{
    
    public class NathanTest
    {
        [Theory]
        [InlineData(new string[] { "test1a", "test2", "test1b", "test1c", "test3" }, new string[] {"Wrong anser", "OK","Runtime error", "OK", "Time limit exceeded" })]
        public void CalculateNathanTest(string[] tests, string[] results)
        {
            //Arrange
            NathanTestScores nathScores = new NathanTestScores();

            //Act
            var result = nathScores.NathScores(tests, results);
            var result2 = nathScores.solution(tests, results);

            //Assert
            Assert.Equal(33, result);
            Assert.Equal(33, result2);
        }

    }
}
