using StackImplementation;
using Xunit;

namespace Algorithms.Test
{
    public class AlgoExpertSearchTest
    {
       
        [Theory]
        [InlineData(new int[7] { 2, 3, 4, 56, 4, 2, 1 }, 5)]
        public void BinarySearchTest(int[] array, int expectedResult)
        {
            //Act
            //Arrange
            int result = AlgoExpertSearch.BinarySearch(array, 4);

            Assert.Equal(result, expectedResult);
        }
    }
    public class AlgoExpertTest
    {

        [Theory]
        [InlineData("([])(){}(())()()", true)]
        [InlineData("{}gawgw()", true)]
        [InlineData("(141[])(){waga}((51afaw))()hh()", true)]
        public void AlgoExpertsStackTest(string input, bool expectedResult)
        {
            //Arrange
            bool result = AlgoExpertsStack.BalancedBrackets(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData("abcdcba", "abcdcba")]
        public void PalindromeCheckTest(string input, string expectedResult)
        {
            //Arrange
            var result = AlgoExpertsStack.PalindromeCheck(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
