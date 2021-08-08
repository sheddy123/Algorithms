using Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Test
{
    public class MergeSortTest
    {
        MergeSort sort = new MergeSort();

        [Theory]
        [InlineData(new int[13] { 9, 2, 6, 7, 5, 4, 3, 1, 8, 20, 30, 12, 45 }, new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 20, 30, 45 })]
        public void SumTest(int[] values, int[] expectedValue)
        {
            //var imp = sort.MergeSortImp(values, 0, 8);
            var imp = sort.MergeSortImp(values, 0, values.Length - 1);
            Assert.Equal(expectedValue, imp);
        }
    }

    public class HasPathDepthFirst
    {
        DepthFirstSearch depthFirst = new DepthFirstSearch();

        [Fact]
       // [MemberData(nameof(HasPathDepthFirst.Data), MemberType = typeof(HasPathDepthFirst))]
        public void HasPath()
        {
            Dictionary<string, string[]> graphValues =    new Dictionary<string, string[]>()
         {
                { "f", new string[] { "g", "i" } },
                 { "g", new string[] { "h" } },
                 { "h", new string[] { } },
                 { "i",   new string[] { "g", "k" } },
                 { "j",   new string[] { "i" } },
                  { "k",  new string[] { } }
         };
            var hasPath = depthFirst.HasPath(graphValues, "f", "k");

            Assert.True(hasPath);

        }
        public static IEnumerable<object[]> Data =>
         new List<object[]>
         {
                new object[] { "f", new string[] { "g", "h" } },
                new object[] { "g", new string[] { "h" } },
                new object[] { "h", new string[] { } },
                new object[] { "i",   new string[] { "g", "k" } },
                new object[] { "j",   new string[] { "i" } },
                new object[]  { "k",  new string[] { } }
         };


    }
}