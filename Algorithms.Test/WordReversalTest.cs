using System;
using Xunit;
using StackImplementation;

namespace Algorithms.Test
{
    public class WordReversalTest
    {
        [Fact]
        public void WordRevers()
        {
            var word = "abcdefghijklmnpqrstuvwxyz";
            WordReversal reverse = new WordReversal(word);
            
            var reversedWord = reverse.reverseString(word);

            Assert.Equal("zyxwvutsrqpnmlkjihgfedcba", reversedWord);

        }
    }
}
