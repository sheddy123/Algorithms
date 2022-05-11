using System;
using System.Collections.Generic;

namespace StackImplementation
{
    
    public class AlgoExpertsStack
    {
        public static bool BalancedBrackets(string str)
        {
            Stack<char> addStringToStack = new Stack<char>();
            foreach (var character in str)
            {
                if (addStringToStack.Count > 0)
                {
                    switch (addStringToStack.Peek())
                    {
                        case '(':
                            if (character == ')')
                            {
                                addStringToStack.Pop();
                                continue;
                            }
                            break;
                        case '[':
                            if (character == ']')
                            {
                                addStringToStack.Pop();
                                continue;
                            }
                            break;
                        case '{':
                            if (character == '}')
                            {
                                addStringToStack.Pop();
                                continue;
                            }
                            break;
                    }
                    if (character == '(' || character == ')')
                    {
                        addStringToStack.Push(character);
                    }
                    if (character == '{' || character == '}')
                    {
                        addStringToStack.Push(character);
                    }
                    if (character == '[' || character == ']')
                    {
                        addStringToStack.Push(character);
                    }

                }
                else if (character == '(' || character == ')' || character == '{' || character == '}' || character == ']' || character == '[')
                {
                    addStringToStack.Push(character);
                }

            }

            return addStringToStack.Count == 0;
        }

        public static string PalindromeCheck(string reverse)
        {
            Stack<char> inputCharacters = new Stack<char>();
            foreach(var character in reverse)
            {
                inputCharacters.Push(character);
            }
            String reversedWord = new String(inputCharacters.ToArray());
            return reversedWord;
        }
    }
}
