using Xunit;
using LeetCode;
using System;
namespace Algorithms.Test
{
    public class MostCommonWordTest
    {
        [Theory]
        [InlineData("a.", new string[] { })]
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
