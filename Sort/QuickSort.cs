using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
   public class QuickSort
    {
        public int[] mySort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public int findSmallest(int[] arr)
        {
            int smallest = arr[0];
            int smallestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }

            }
            return smallestIndex;
        }

        public int[] selectionSort(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                int smallest = findSmallest(arr);
                newArr[i] = arr[smallest];
                arr = arr.Where(x => x != arr[smallest]).ToArray();
            }
            return newArr;
        }

        public int Partitioning(int[] array, int low, int high)
        {
            int pivot = array[low];
            int i = low;
            int j = high;
            while (i < j)
            {
                while (array[i] <= pivot && i <= high)
                {
                    i++;
                    if (i > high)
                        break;
                }
                while (array[j] >= pivot && j >= low)
                {
                    j--;
                    if (j <= low)
                        break;
                }
                if (i < j)
                {
                    Swap(array, i, j);
                }
            }

            int temp = array[low];
            array[low] = array[j];
            array[j] = temp;

            return j;
        }

        public void QuickSorts(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partitioning(array, low, high);
                QuickSorts(array, low, pi);
                QuickSorts(array, pi + 1, high);
            }
        }
        public void Swap(int[] array, int low, int high)
        {
            int temp = array[low];
            array[low] = array[high];
            array[high] = temp;
        }


        #region QuickSort
        /// <summary>
        /// Best Implementation by far for QuickSort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public int[] QuickSortss(int[] array, int low, int high)
        {
            if(low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortss(array, low, pivotIndex-1);
                QuickSortss(array, pivotIndex+1, high);
            }
            return array;
        }

        public int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int partitionIndex = start;
            for(int i=start; i<end; i++)
            {
                if(array[i] <= pivot)
                {
                    Swap(array, i, partitionIndex);
                    partitionIndex++;
                }
            }
            Swap(array, partitionIndex, end);
            return partitionIndex;
        }

//      Write a function:
//      class Solution { public int solution(int[] A); }
//      that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.
//      For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
//      Given A = [1, 2, 3], the function should return 4.
//      Given A = [−1, −3], the function should return 1.
//      Write an efficient algorithm for the following assumptions:
//      N is an integer within the range[1..100, 000];
//      each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].


        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length < 1)
                return 0;
            var addArray = new HashSet<int>(A.ToList());
            A = addArray.ToArray();
            Array.Sort(A);
            if (A[(A.Length - 1)] < 0)
                return 1;
            //[1,2,3,4,6]
            for (int i= 0; i<A.Length-1; i++)
            {
                int nextNumber = A[(i + 1)];
                if ((A[i]+1) != nextNumber)
                {
                    var vad = int.MaxValue;
                    int ma = int.MinValue;
                    return (A[i] + 1);
                }
            }
            return A[(A.Length - 1)] + 1;
        }
        #endregion
    }
}
