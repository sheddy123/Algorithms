using System.Collections.Generic;

namespace Sorting
{
    public class AlgoExpertsSorting
    {
        public static List<int> RiverSizes(int[,] matrix)
        {
            //Store visited to prevent infinite cycles
            HashSet<string> storeVisited = new HashSet<string>();
            //Increase the sizes of all rivers visted that are adjacent to each other
            List<int> totalRiverSize = new List<int>();
            //Get the rowLength or the width of the matrix
            int rowLength = matrix.GetLength(0);
            //Get the columns length or the height of the matrix given
            int columnLength = matrix.GetLength(1);

            int count = 0;

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < columnLength; col++)
                {
                    if (ExploreIsland(matrix, row, col, storeVisited))
                    {
                        count += 1;
                    }
                }
            }

            if (count != 0)
                totalRiverSize.Add(count);

            // Write your code here.
            return totalRiverSize;
        }

        public static bool ExploreIsland(int[,] matrix, int row, int col, HashSet<string> visitedSet)
        {
            bool lessThanRowLength = row >= 0 && row < matrix.GetLength(0);
            bool lessThanColLength = col >= 0 && col < matrix.GetLength(1);
            string key = row + "," + col;

            if (!lessThanColLength || !lessThanRowLength)
            {
                return false;
            }

            if (visitedSet.Contains(key))
            {
                return false;
            }

            visitedSet.Add(key);

            if (matrix[row, col] == 0)
                return false;

            //Moving up
            ExploreIsland(matrix, row - 1, col, visitedSet);
            //Moving right
            ExploreIsland(matrix, row, col + 1, visitedSet);
            //Moving down
            ExploreIsland(matrix, row + 1, col, visitedSet);
            //Moving left
            ExploreIsland(matrix, row, col - 1, visitedSet);
    

        return true;

        }
        public static void Swap(int[] array, int firstNum, int secondNum)
        {
            int temp = array[firstNum];
            array[firstNum] = array[secondNum];
            array[secondNum] = temp;
        }

        public int[] BubbleSort(int[] array)
        {
            int length = array.Length;

            for(int i = 0; i<length; i++)
            {
                for(int j=0; j<length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }

            return array;
        }

        public int[] SelectionSort(int[] array)
        {
            int length = array.Length;
            //[64, 25, 12, 22, 11]
            //[25, 64, 12, 22, 11]
            //[12, 64, 25, 22, 11]
            //[12,64, 25, 22, 11]
            //[11,64,25,22,12]
            for (int i = 0; i < length; i++)
            {
                int min_Index = i;
                //j will be increasing until it gets the least element while i remain constant in order to place the element at j in the appropriate position
                //while iterating, we keep track of the minimum index so far
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[min_Index])
                        min_Index = j;
                }
                //i will remain constant
                Swap(array, min_Index, i);
                
            }
            return array;
        }

        public int[] InsertionSort(int[] array)
        {
            //Get length of the array
            int length = array.Length - 1;

            //iterate through the array while counter is less than the length of the array
            //set initial value of counter to 1 in order to set inner loop's value down by 1
            for(int i = 1; i<=length; i++)
            {
                int key = array[i];
                int j = i - 1;

                //iterate through the array while j is less than or equal to zero and the value/element at j is greater than the key we are comparing
                while(j >=0 && array[j] > key)
                {
                    //push elements forward until we encounter a value that is less than the key
                    array[j + 1] = array[j];
                    //decrement j by 1
                    j = j - 1;
                }

                array[j + 1] = key;
            }

            return array;
        }
    }

}

