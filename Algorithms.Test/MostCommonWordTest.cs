using Xunit;
using LeetCode;
using System;
namespace Algorithms.Test
{
    public class MostCommonWordTest
    {
        [Theory]
        [InlineData("Bob!", new string[] { "hit"})]
        public void MostCommonTest(string paragraph, string[] banned)
        {
            //Arrange
            MostCommon mostCommon = new MostCommon();

            //Act
            var result = mostCommon.MostCommonWord(paragraph, banned);

            //Assert
            Assert.Equal("a", result);
        }
    }
}
