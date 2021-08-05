using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveDuplicatesSortedArray
    {
        public int ReoveDuplicates(int[] nums)
        {
            int k = removeDuplicates(nums);
            return k;

        }

        public int removeDuplicates(int[] nums)
        {
            int index = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[index++] = nums[i + 1];
                }
            }
            return index;
        }
    }
}
