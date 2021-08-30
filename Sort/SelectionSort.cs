using System;
using System.Linq;

namespace Sorting
{

    public class SelectionSort
    {
        //{12,45,6,2,2,5,3,7,8,0}

        public int[] Selection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int iMax = i;
                for(int j = i+1; j<array.Length; j++)
                {
                    if(array[j] < array[iMax])
                    {
                        iMax = j;
                    }
                }
                int temp = array[i];
                array[i] = array[iMax];
                array[iMax] = temp;
            }
            return array;
        }

    }
}