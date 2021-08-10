using Searching;
using System;
using Xunit;

namespace Algorithms.Test
{
    public class BinarySearchTest
    {
        BinarySearch binarySearch = new BinarySearch();

        [Theory]
        [InlineData(new int[11] { 0,1,2,3,4,5,6,7,8,9,10}, 10)]
        public void BinarySearch(int[] initialArray, int expectedValue)
        {
            var expectedOne = binarySearch.BinarySearchImp(initialArray, 0, 10, 10);
            var expectedTwo = binarySearch.BinSearch(initialArray, 0, 10, 10);

            Assert.Equal(expectedValue, expectedOne);
            Assert.Equal(expectedValue, expectedTwo);
        }
    }
}
