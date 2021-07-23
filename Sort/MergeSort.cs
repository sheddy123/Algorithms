using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class MergeSort
    {
        public void TwoWayMergeSort(int[] array,int middle,int leftIndex, int rightIndex)
        {
            int[] temp = new int[rightIndex - leftIndex + 1];
            int i = leftIndex; int j = middle + 1;
            int k = 0;
            
            //Check if the index in the left sub-array is less than or equal to the end which is middle in this case and
            //Also check if the index in the right sub-array is less than or equal to the end which is the rightIndex in this case
            while(i<=middle && j <= rightIndex)
            {
                //Check if the data in the left sub-array is less than data in the right sub-array
                if(array[i]<array[j])
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    //Check if the data in the right sub-array is less than data in the right sub-array
                    temp[k++] = array[j++];
                }
            }

            //Condition where there are values left in the left sub-array after the right array has been exhausted
            for(;i<=middle; i++)
                temp[k++] = array[i];

            //Condition whether there are values left in the right sub-array after the left array has been exhausted
            for (;j<=rightIndex; j++)
                temp[k++] = array[j];

            for (i= leftIndex; i <= rightIndex; i++)
                array[i] = temp[i - leftIndex];
        }
        public int[] MergeSortImp(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = ((left + right)/2);
                MergeSortImp(array, left, mid);
                MergeSortImp(array, mid + 1, right);
                TwoWayMergeSort(array,mid, left, right);
            }
            return array;
        }

    }
}
