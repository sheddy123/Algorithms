using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveElements
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length < 0)
                return 0;
            int index = 0;
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[index++] = nums[i]; 
                }
            }
            return index;
        }
    }
}
