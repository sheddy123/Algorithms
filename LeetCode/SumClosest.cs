using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int currentIterator = 0;
            int previous = 0;
            int current = 0;
            Array.Sort(nums);
            for (int i=0; i< nums.Length; i++)
            {
                int left = i;
                int right = currentIterator + 2;

                while(right < nums.Length)
                {
                    int sum = nums[left] + nums[left + 1] + nums[right];
                    if (sum> target || ((left+1) == nums.Length -1))
                        return sum;
                    if(current > previous)
                    {
                        return previous;
                    }
                    if(left == nums.Length -3 || left == nums.Length - 2)
                    {
                        previous = sum;
                        currentIterator = -3;
                        right = 0;break;
                    }
                    right++;
                }
                currentIterator++;
            }
            return 0;
        }
       
    }
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int diff = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int lo = i + 1;
                int hi = nums.Length - 1;
                while (lo < hi)
                {
                    int sum = nums[i] + nums[lo] + nums[hi];
                    if (Math.Abs(sum - target) < Math.Abs(diff))
                        diff = target - sum;

                    if (sum < target)
                        lo++;
                    else
                        hi--;

                    if (diff == 0)
                        break;
                }

            }
            return target - diff;
        }
    }
}
