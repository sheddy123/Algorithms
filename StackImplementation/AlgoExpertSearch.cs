using System;
namespace StackImplementation
{
    public class AlgoExpertSearch
    {
        public static int BinarySearch(int[] array, int target)
        {
            Array.Sort(array);
            int left = 0, right = array.Length - 1, mid = 0;
            while(left <= right)
            {
                mid = ((left + right) / 2);
                if (array[mid] == target)
                    return mid;
                else if (target < array[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return mid;
        }

        
    }
}
