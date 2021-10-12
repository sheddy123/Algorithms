using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{

    public class SelectionSort
    {
        //{12,45,6,2,2,5,3,7,8,0}

        public int[] Selection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int iMax = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[iMax])
                    {
                        iMax = j;
                    }
                }
                int temp = array[i];
                array[i] = array[iMax];
                array[iMax] = temp;
            }
            return array;
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int i = 0; int j = 0; int max = 0;
            HashSet<char> containsElement = new HashSet<char>();
            while (i < s.Length)
            {
                while (containsElement.Contains(s[i]))
                {
                    containsElement.Remove(s[j]);
                    ++j;
                }
                containsElement.Add(s[i]);
                max = Math.Max(max, i - j + 1);
                i++;
            }
            return max;
        }
    }
}