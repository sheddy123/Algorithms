using System;

namespace Searching
{
    public class BinarySearch
    {
        public int BinarySearchImp(int[] array, int left,int right, int x)
        {
            //base case
            var roundedNum = Math.Round(Convert.ToDouble(left + right)/2);
            int mid = Convert.ToInt32(roundedNum);
            if (x == array[mid])
                return mid;

            if (x < array[mid])
                return BinarySearchImp(array, left, mid - 1, x);
            
            return BinarySearchImp(array, mid + 1, right, x);
        }

    }
}
