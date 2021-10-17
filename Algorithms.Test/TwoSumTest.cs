using LeetCode;
using System;
using Xunit;

namespace Algorithms.Test
{
    public class TwoSumTest
    {
        

        [Theory]
        [InlineData(new int[3] { 3,2,4 }, 6)]
        [InlineData(new int[2] { 3,3 }, 6)]
        [InlineData(new int[4] { 2,7,11,15 }, 9)]
        public void TwoSum1(int[] nums, int target)
        {
            //Arrange
            TwoSum.Solution twoSum = new TwoSum.Solution();

            //Act
            var output = twoSum.TwoSum2(nums, target);

            //Assert
            Assert.Equal(new int[2] { 1, 2 }, output);
        }
    }
}
