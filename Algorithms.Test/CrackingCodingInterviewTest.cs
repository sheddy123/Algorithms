using System;
using Xunit;
using CrackingCodingInterview;

namespace Algorithms.Test
{
    public class CrackingCodingInterviewTest
    {
        StringArrays stringTest = new StringArrays();

        [Theory]
        [InlineData("abcdefghijklmnopqrstuvwxhhjyz")]
        public void IsUnique(string stringToTest)
        {
            var result = stringTest.IsUnique(stringToTest);

            Assert.False(result);
        }
    }
}
