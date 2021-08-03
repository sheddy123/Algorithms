using System;
using Xunit;
using StackImplementation;
using LeetCode;

namespace Algorithms.Test
{
    public class ThreeSumClosestTest
    {
        SumClosest sumClosest = new SumClosest();

        [Theory]
        [InlineData(new int[4] { 0, 2, 1,-3 }, 0)]
        public void Three_SumClosest(int[] values, int expectedValues)
        {
            var _sumClosest = sumClosest.ThreeSumClosest1(values, 1);
            
            Assert.Equal(expectedValues, _sumClosest);

        }
    }
}
