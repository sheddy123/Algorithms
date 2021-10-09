using System;
using Xunit;
using Codilityy;


namespace Algorithms.Test
{
    public class WindowSlidingTest
    {
        WindowSlidingTechnique windowSlide = new WindowSlidingTechnique();

        [Theory]
        [InlineData(new int[9] { 1, 4, 2, 10, 2, 3, 1, 0, 20 }, 4, 24)]
        public void MaxElement(int[] arr, int k, int expectedValue)
        {
            var maxValue = windowSlide.SlideMaxItem(arr, arr.Length, k);
            var maxValue2 = WindowSlidingTechnique.maxSum(arr, arr.Length, k);

            Assert.Equal(expectedValue, maxValue);
            Assert.Equal(expectedValue, maxValue2);
        }
    }
}
