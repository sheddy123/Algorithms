using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class BubbleSort
    {
        public int[] SortBubble(int[] array)
        {
            for(int i=0; i < array.Length; i++)
            {
                for(int j=i+1; j<array.Length -1; j++)
                {
                    if(array[j] < array[i])
                        Swap(j, i, array);
                 
                }
            }
            return array;
        }
        public void Swap(int j, int i, int[] array)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
