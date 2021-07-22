using Xunit;
using Recursion;


namespace Algorithms.Test
{
    public class PalindromeTest
    {
        [Theory]
        [InlineData("sasdrdsas", true)]
        public void IsPalindrome(string word, bool expectedResult)
        {
            Palindrome palindrome = new Palindrome(word);
            var isPalindrome = palindrome.IsPalindrome(word.Length);

            Assert.Equal(expectedResult, isPalindrome);

        }
    }
}
