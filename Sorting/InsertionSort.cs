using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class InsertionSort
    {
        public void Insert_Sort(int[] array)
        {
            for(int i=1; i<array.Length; i++)
            {
                int current = array[i];
                int previous = i - 1;
                while(previous >= 0 && array[previous] > current)
                {
                    array[previous + 1] = array[previous];
                    previous--;
                }
                array[previous + 1] = current;
            }
            
        }
    }
}
