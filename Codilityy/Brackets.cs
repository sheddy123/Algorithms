using System;
using System.Collections.Generic;

namespace Codilityy
{
    //A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:
    //S is empty; S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string; S has the form "VW" where V and W are properly nested strings.
    //For example, the string "{[()()]}" is properly nested but "([)()]" is not.
    //    Write a function:
    //class Solution { public int solution(String S); }
    //that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.
    //For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above
    //Write an efficient algorithm for the following assumptions: N is an integer within the range[0..200, 000];
    //string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
    
    class Brackets
    {
        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (!String.IsNullOrEmpty(S))
            {
                Stack<char> addCharacters = new Stack<char>();
                for (int i = 0; i < S.Length; i++)
                {
                    var characterToCheck = S[i];
                    switch (characterToCheck)
                    {
                        case '}':
                            if (addCharacters.Count == 0 || addCharacters.Pop() != '{')
                            {
                                return 0;
                            }
                            break;
                        case ']':
                            if (addCharacters.Count == 0 || addCharacters.Pop() != '[')
                            {
                                return 0;
                            }
                            break;
                        case ')':
                            if (addCharacters.Count == 0 || addCharacters.Pop() != '(')
                            {
                                return 0;
                            }
                            break;
                        default: addCharacters.Push(characterToCheck); break;
                    }
                }
                return 1;
            }
            return 0;
        }
    }

}
