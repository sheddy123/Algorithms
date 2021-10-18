using System;
using LeetCode;
using Xunit;

namespace Algorithms.Test
{
    public class MedianSortedArrayTest
    {

        

        [Theory]
        [InlineData(new int[2] { 1,2}, new int[2] { 3, 4 })]
        public void FindMedianSortedArray(int[] nums1, int[] nums2)
        {
            //Arrange
            MedianSortedArray sorted = new MedianSortedArray();
            
            //Act
            var result = sorted.FindMedianSortedArrays(nums1, nums2);

            //Assert
            Assert.Equal(2.5, result);
        }
    }
}
