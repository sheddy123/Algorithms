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
                if (stringToCompress[i] == stringToCompress[i+1])
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
            for(int i =1; i<=(stringToCompress.Length -1); i++)
            {
                if(stringToCompress[currentIndex] == stringToCompress[i])
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
                        sb.Append(stringToCompress[(i -1)] + (count).ToString());
                    
                    count = 1;
                    currentIndex = i;
                }
            }
            return sb.ToString();
        }

    }
}