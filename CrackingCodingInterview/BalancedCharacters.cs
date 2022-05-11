using System;
using System.Collections.Generic;
using System.Linq;

namespace CrackingCodingInterview
{
    public class BalancedCharacters
    {
        public int AmazonBalancedCharacters(string S)
        {
            if (S.Length % 2 != 0)
            {
                return 0;
            }
            string newStringComparison = string.Empty;
            int numberOfQuestionMarks = 0;
            foreach (var characterValue in S)
            {
                if (characterValue == '?')
                    numberOfQuestionMarks++;
                else
                    newStringComparison += characterValue;
            }
          
            
            Stack<char> firstBracketType = new Stack<char>();
            Stack<char> secondBracketType = new Stack<char>();
            int leftPointer = 0;
            int rightPointer = leftPointer + 1;
            while (leftPointer <= newStringComparison.Length - 2)
            {
                if(rightPointer == newStringComparison.Length)
                {
                    leftPointer = leftPointer + 1;
                    rightPointer = leftPointer + 1;
                }

                switch (newStringComparison[leftPointer])
                {
                    case ']':
                        if (newStringComparison[rightPointer] == '[')
                        {
                            leftPointer++; rightPointer = leftPointer + 1;
                            continue;
                        }
                        //else if (rightPointer == newStringComparison.Length - 1)
                        //{
                        //    firstBracketType.Push(newStringComparison[leftPointer]);
                        //    leftPointer++; rightPointer = leftPointer + 1;
                        //    continue;
                        //}
                        break;
                    case '[':
                        if (newStringComparison[rightPointer] == ']')
                        {
                            leftPointer++; rightPointer = leftPointer + 1;
                            continue;
                        }
                        //else if (rightPointer == newStringComparison.Length - 1)
                        //{
                        //    firstBracketType.Push(newStringComparison[leftPointer]);
                        //    leftPointer++; rightPointer = leftPointer + 1;
                        //    continue;
                        //}
                        break;
                    case '(':
                        if (newStringComparison[rightPointer] == ')')
                        {
                            leftPointer++; rightPointer = leftPointer + 1;
                            continue;
                        }
                        //else if (rightPointer == newStringComparison.Length - 1)
                        //{
                        //    secondBracketType.Push(newStringComparison[leftPointer]);
                        //    leftPointer++; rightPointer = leftPointer + 1;
                        //    continue;
                        //}
                        break;
                    case ')':
                        if (newStringComparison[rightPointer] == ')')
                        {
                            leftPointer++; rightPointer = leftPointer + 1;
                            continue;
                        }
                        //else if (rightPointer == newStringComparison.Length - 1)
                        //{
                        //    secondBracketType.Push(newStringComparison[leftPointer]);
                        //    leftPointer++; rightPointer = leftPointer + 1;
                        //    continue;
                        //}
                        break;
                }
                if (rightPointer == newStringComparison.Length - 1)
                {
                    secondBracketType.Push(newStringComparison[leftPointer]);
                    leftPointer++; rightPointer = leftPointer + 1;
                    continue;
                }
                rightPointer = rightPointer + 1;
            }

            int temp = numberOfQuestionMarks;

            while(firstBracketType.Count > 0 && temp > 0)
            {
                firstBracketType.Pop();
                temp--;
            }
            
            while(secondBracketType.Count > 0 && temp > 0)
            {
                secondBracketType.Pop();
                temp--; 
            }

            return ((firstBracketType.Count == 0) && (secondBracketType.Count == 0)) ? numberOfQuestionMarks : 0;
        }

        public string CaesarCipherEncryptor(string str, int key)
        {
            return Functions.CaesarCipherEncrypt(str, key);
        }
    }

    public static class Functions
    {
        public static string CaesarCipherEncrypt(string str, int key)
        {
            string alphabets = "abcdefghijklmnopqrstuvwxyz";
            List<char> alphabetSets = new List<char>(str);
            //C = E(p,k) To Cipher == C = (index of alphabet + key) modulus 26
            //P = E(c,k) To Decipher == P = (cipher text - key) modulus 26
            for(int i =0; i<str.Length; i++)
            {
                var characterIndex = ((alphabets.IndexOf(str[i]) + key) % 26);
                alphabetSets[i] = alphabets[characterIndex];
            }
            alphabets = string.Join("", alphabetSets);
            return alphabets;
        }
    }
}