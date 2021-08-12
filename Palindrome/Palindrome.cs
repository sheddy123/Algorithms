using System;
using System.Collections;

namespace Recursion
{
    public class Palindrome
    {
        private int lengthTracker;
        private string inputText;
        public Palindrome(string input)
        {
            lengthTracker = input.Length;
            inputText = input;
        }

        public bool IsPalindrome(int length)
        {
            //base case
            if (length == 0 || length == 1)
                return true;

            //smallest amount of work to be performed by the recursive function

            if (inputText[0] == inputText[length - 1])
            {
                lengthTracker = inputText.Substring(1, length-1).Length;//kayak
                inputText = inputText.Substring(1, lengthTracker-1);
                return IsPalindrome(lengthTracker -1);
            }
            return false;
        }
    }
}
