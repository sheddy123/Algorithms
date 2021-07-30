using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class TwoSortedArray
    {
        //Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        //The overall run time complexity should be O(log (m+n)).
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> array1 = new List<int>(nums1);
            List<int> array2 = new List<int>(nums2);


            array1.AddRange(array2);
            //  array1.Sort();

            int[] mergedArray = array1.ToArray();//new int[array1.Count];//array1.ToArray();
                                                 //   array1.CopyTo(mergedArray);
            Array.Sort(mergedArray);
            int mergedIndex = (array1.Count / 2);

            if (array1.Count == 1)
            {
                return mergedArray[0];
            }
            if (array1.Count % 2 == 0)
            {
                var i1 = mergedArray[mergedIndex - 1];
                var i2 = mergedArray[mergedIndex];


                return Convert.ToDouble(Decimal.Divide((i1 + i2), 2));
            }
            else
            {
                //Console.WriteLine(Convert.ToDouble((i1+i2)/2));]

                //Console.WriteLine(array1.Count());
                return mergedArray[mergedIndex];
            }
        }
    }
}
