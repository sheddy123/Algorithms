using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class MedianSortedArray
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var copied_array = new List<int>();
            copied_array.AddRange(nums1);
            copied_array.AddRange(nums2);
            nums1 = copied_array.ToArray();
            Array.Sort(nums1);

            int middle = nums1.Length / 2;
            if (nums1.Length == 1)
                return nums1[0];

            if ((nums1.Length % 2) == 0)
            {
                double median = nums1[middle] + nums1[(middle - 1)];
                median = median / 2;
                return median;
            }
            return nums1[middle];
        }
    }
}

