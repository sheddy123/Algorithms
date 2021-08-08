using Sorting;
using Xunit;

namespace Algorithms.Test
{
    public class MergeSortTest
    {
        MergeSort sort = new MergeSort();

        [Theory]
        [InlineData(new int[13] { 9,2,6,7,5,4,3,1,8,20,30,12,45}, new int[13] { 1, 2, 3, 4, 5,6,7,8,9,12,20,30,45 })]
        public void SumTest(int[] values, int[] expectedValue)
        {
            //var imp = sort.MergeSortImp(values, 0, 8);
            var imp = sort.MergeSortImp(values,0,values.Length-1);
            Assert.Equal(expectedValue, imp); 
        }
    }

}
