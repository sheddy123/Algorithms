using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingCodingInterview
{
    public class StringArrays
    {
        public bool IsUnique(string stringToTest)
        {
            HashSet<char> stringSet = new HashSet<char>(stringToTest.ToCharArray());
            if (stringToTest.Length == stringSet.Count)
                return true;
            return false;

        }

        public string CompressString(string stringToCompress)
        {
            int count = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < stringToCompress.Length - 2; i++)
            {
                if (stringToCompress[i] == stringToCompress[i + 1])
                {
                    var ddd = sb.ToString();

                    count++;
                    sb.Append(stringToCompress[i] + count);
                    count = 0;
                }
            }

            return sb.ToString() == stringToCompress ? stringToCompress : sb.ToString();

        }

        public string CompressInput(string stringToCompress)
        {
            HashSet<char> stringSet = new HashSet<char>(stringToCompress.ToCharArray());
            if (stringSet.Count == stringToCompress.Length)
                return stringToCompress;

            int currentIndex = 0; int count = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= (stringToCompress.Length - 1); i++)
            {
                if (stringToCompress[currentIndex] == stringToCompress[i])
                {
                    count = count + 1;
                }
                if (stringToCompress[currentIndex] != stringToCompress[i] || i == (stringToCompress.Length - 1))
                {
                    if (count != 1)
                    {

                        sb.Append(stringToCompress[currentIndex] + (count).ToString());
                    }
                    else
                        sb.Append(stringToCompress[(i - 1)] + (count).ToString());

                    count = 1;
                    currentIndex = i;
                }
            }
            return sb.ToString();
        }

        public string RunLengthEncoding(string str)
        {
            // Write your code here.
            if (str.Length < 0)
            {
                return String.Empty;
            }
            if (str.Length == 1)
            {
                return string.Format("1{0}", str);
            }

            int i = 0;
            int j = i + 1;
            int count = 1;
            List<string> stringToAppend = new List<string>();
            while (i < str.Length)
            {
                if (str[i] == str[j] && count < 9)
                {
                    count += 1;
                }
                else
                {
                    string numToAdd = $"{count}{str[i]}";
                    stringToAppend.Add(numToAdd);
                    count = 1;
                    i = j;
                }

                if (j == str.Length - 1 && str[i] == str[j])
                {
                    string numToAdd = $"{count}{str[i]}";
                    stringToAppend.Add(numToAdd);
                    count = 1;
                    i = j;
                }
                if (j == str.Length - 1 && str[i] != str[j])
                {
                    string numToAdd = $"{count}{str[i]}";
                    stringToAppend.Add(numToAdd);
                    stringToAppend.Add($"{count}{str[j]}");
                    break;
                }

                if (j < str.Length - 1)
                {
                    j += 1;
                }
                if (i == str.Length - 1)
                {
                    break;
                }
            }
            return string.Join("", stringToAppend);
        }

        public int FirstNonRepeatingCharacter(string str)
        {
            // Write your code here.
            if (str.Length < 0)
            {
                return -1;
            }
            if (str.Length == 1)
            {
                return 0;
            }
            HashSet<string> storeCharacters = new HashSet<string>();


            int i = 0;
            int j = str.Length - 1;
            while (i < str.Length)
            {
                if (str[i] == str[j])
                {
                    storeCharacters.Add(str[i].ToString());
                    i++;
                    j = str.Length - 1;
                }
                else
                {
                    if ((i + 1 == j) && !storeCharacters.Contains(str[i].ToString()))
                    {
                        return i;
                    }
                    if (i + 1 == str.Length - 1)
                        return i;
                    else if (i + 1 == j)
                    {
                        i++;
                        j = str.Length - 1;
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            return -1;
        }

        public int FirstNonRepeatingCharac(string input)
        {
            if(input.Length < 0)
            {
                return -1;
            }

            if(input.Length == 1)
            {
                return 0;
            }
            HashSet<char> storePreviousCharacters = new HashSet<char>();
            int i = 0, j = input.Length - 1;
            while(i < input.Length)
            {
                if(input[i] == input[j])
                {
                    storePreviousCharacters.Add(input[i]);
                    i += 1;
                    j = input.Length - 1;
                }
                else
                {
                    j--;
                }
                if(i == j && !storePreviousCharacters.Contains(input[i]))
                {
                    return i;
                }
                if(i == input.Length - 1 && !storePreviousCharacters.Contains(input[i]))
                {
                    return i;
                }
                if (i == input.Length - 1 && storePreviousCharacters.Contains(input[i]))
                {
                    break;
                }

            }

            return -1;
        }
        public static string LongestPalindromicSubstring(string str)
        {
            // Write your code here.
            if (str.Length < 0)
            {
                return "";
            }
            string longestPalindromicSubstring = "";
            int i = 0;
            int j = i + 1;
            int currentLength = 0;

            while (i < str.Length)
            {
                //Get current word
                string currentWord = str[i..j];
                //Reverse the currentWord, and check if it forms a palindrome
                string checkPalindrome = ReverseStrings(currentWord);

                //Compare reversed string with currentWord
                if (currentWord == checkPalindrome)
                {
                    //Check if the currentWords length is greater than currentLength
                    if (currentWord.Length > currentLength)
                    {
                        //Set longestPalindromicSubstring to current word
                        longestPalindromicSubstring = currentWord;
                        //Update the currentLength
                        currentLength = currentWord.Length;
                    }
                }
                //Check if i == str.Length - 1 to break from loop
                if (i == str.Length - 1)
                {
                    break;
                }
                //Check if j == str.Length - 1 to update i, j
                if (j == str.Length)
                {
                    i += 1;
                    j = i + 1;
                }
                else
                {
                    j++;
                }
            }
            return longestPalindromicSubstring;
        }
        public static string ReverseStrings(string input)
        {
            if (input == "")
            {
                return "";
            }
            return ReverseStrings(input.Substring(1)) + input[0];
        }
    }
}