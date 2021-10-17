using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class TwoSum
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {

                List<int> storeArray = new List<int>(nums);
                int[] newArray = new int[2];
               
                int result = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    result = target - nums[i];

                    storeArray[i] = result == nums[i] ? (nums[i] + 1) : 0;
                    if (storeArray.Contains(result))
                    {
                        newArray[0] = i;
                        newArray[1] = storeArray.IndexOf(result);
                        return newArray;
                    }

                    storeArray[i] = nums[i];
                    
                }
                return nums;
            }

            public int[] TwoSum1(int[] nums, int target)
            {
                int window_sum = 0;
                int two_num = 2;
                List<int> addSum = new List<int>();
                for (int i = 0; i < two_num; i++)
                {
                    window_sum += nums[i];

                    if (window_sum == target)
                    {
                        addSum.Add(i - 1);
                        addSum.Add(i);
                        return addSum.ToArray();
                    }
                }

                for (int i = two_num; i < nums.Length; i++)
                {
                    window_sum += nums[i] - nums[i - two_num];
                    if (window_sum == target)
                    {
                        addSum.Add(i - 1);
                        addSum.Add(i);
                        return addSum.ToArray();
                    }
                }
                return addSum.ToArray();

            }

            public int[] TwoSum2(int[] nums, int target)
            {
                int i = 0; int j = nums.Length - 1;

                while (i < j)
                {
                    int sum = nums[i] + nums[j];

                    if (sum == target)
                        return new int[] { i, j };

                    if (i == j || ((i + 1) == j))
                    {
                        i++;
                        j = nums.Length - 1;
                    }
                    else
                    {
                        j--;
                    }
                }
                return new int[] { -1, -1 };

            }
            //Second and slower 
            //public int[] TwoSums(int[] nums, int target)
            //{

            //    List<int> storeArray = new List<int>(nums);

            //    int result = 0;

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        result = target - nums[i];

            //        //nums[i] = 0;
            //        if (storeArray.Contains(result) && nums[i] != result)
            //        {

            //            int[] newArray = new int[2] { i, Array.IndexOf(nums, result) };
            //            return newArray;
            //        }
            //        else if (storeArray.Contains(result) && nums[i] == result)
            //        {
            //            storeArray[i] = -1;
            //            nums[i] = -1;
            //            if (storeArray.Contains(result))
            //            {

            //                int[] newArray = new int[2] { i, Array.IndexOf(nums, result) };
            //                return newArray;
            //            }

            //        }

            //    }
            //    return nums;
            //}
        }
    }
}
