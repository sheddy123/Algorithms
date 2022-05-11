using System.Collections.Generic;
using System;
using System.Linq;

namespace Codilityy
{
    public class Arrays
    {
        #region Smallest Difference
        /*
         * Write a function that takes in two non-empty arrays of integers, finds the pair of numbers (one from each array)
         * whose absolute difference is closest to zero, and returns an array containing these two numbers, with the number
         * from the first array in the first position.
         * 
         * Note that the absolute difference of two integers is the distance between them on the real number line. For example,
         * the absolute difference of -5 and 5 is 10, and the absolute difference of -5 and -4 is 1.
         * 
         * You can assume that there will be one pair of numbers with the smallest difference.
         * 
         * Sample Input
         * 
         * arrayOne = [-1, 5, 10, 20, 28, 3]
         * arrayTwo = [26, 134, 135, 15, 17]
         * 
         * Sample Output
         * [28, 26]
        
         */
        public int[] SmallestDifference(int[] array1, int[] array2)
        {
            int[] result = new int[2] { 0, 0 };
            int start = 0;
            int end = 0;
            int absoluteDifference = 0;
            int smallestNumber = int.MaxValue;

            //check if the length of both arrays is greater than 0
            if (array1.Length < 1 && array2.Length < 1)
            {
                return result;
            }

            while (start < array1.Length)
            {

                absoluteDifference = Math.Abs(array1[start] - array2[end]);

                if (absoluteDifference == 0)
                    break;
                if (absoluteDifference < smallestNumber)
                {
                    smallestNumber = absoluteDifference;
                    result = new int[2] { array1[start], array2[end] };
                }


                if (end == array2.Length - 1)
                {
                    start = start + 1;
                    end = 0;
                }
                else
                {
                    end++;
                }
            }

            return result;
        }
        #endregion

        #region Move Element to End
        /*
         *You're given an array of integers and an integer.
         *Write a function that moves all instances of that integer in the array to the end of the array and
         *returns the array.
         *
         *The function should perform this in place (i.e. it should mutate the input
         *array) and doesn't need to maintain the order of the other integers.
         *
         *Sample Input
         *array = [2,1,2,2,2,3,4,2]
         *toMove = 2
         *
         *Sample Output
         *[1,3,4,2,2,2,2,2,]//The numbers 1,3, and 4 could be order differently 
         */
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            // Write your code here.
            var arrayToMove = array.ToArray();
            int left = 0;
            int right = arrayToMove.Length - 1;
            while (left < arrayToMove.Length - 1)
            {
                if (left > right)
                {
                    break;
                }

                //If the element to move at the end is same with normal element and right element,
                //decrease right by 1
                if (arrayToMove[left] == arrayToMove[right] && arrayToMove[right] == toMove)
                {
                    right--;
                }
                else if (arrayToMove[left] == toMove)
                {
                    int temp = arrayToMove[right];
                    arrayToMove[right] = arrayToMove[left];
                    arrayToMove[left] = temp;
                    left++; right--;
                }
                else if (arrayToMove[left] != arrayToMove[right] && arrayToMove[right] != toMove)
                {
                    left++;
                }
                else
                {
                    right--; ;
                }

            }
            return arrayToMove.ToList();
        }

        #endregion

        #region Fibonacci
        public double Fibonacci(int number, Dictionary<int, double> memoObj)
        {
            if (memoObj.ContainsKey(number))
                return memoObj[number];

            if (number <= 2)
                return 1;

            memoObj[number] = Fibonacci(number - 1, memoObj) + Fibonacci(number - 2, memoObj);

            return memoObj[number];
        }

        #endregion

        #region LongestPeak
        public int LongestPeak(int[] array)
        {
            string fhhd = "";
            var d = Convert.ToInt32(fhhd.Split(" ")[0]);
            int lengthOfArray = array.Length;

            if (lengthOfArray < 2)
            {
                return 0;
            }

            int i = 0, j = i + 1, count = 1;
            bool strictlyIncreasing = false, strictlyDecreasing = false;

            while (j < lengthOfArray)
            {

                if (array[j] > array[i])
                {
                    strictlyIncreasing = true;
                    count++;
                }

                else if (array[j] < array[i] && count >= 2)
                {
                    strictlyDecreasing = true;
                    count++;
                }
                else if (array[j] == array[i])
                {
                    strictlyDecreasing = false;
                    strictlyIncreasing = false;
                    count = 1;
                }

                if (strictlyDecreasing && strictlyIncreasing)
                {
                    break;
                }
                i++;
                j++;
            }

            return (strictlyDecreasing && strictlyIncreasing) ? count : 0;
        }
        #endregion

        #region FirstDuplicateValue
        public int FirstDuplicateValue(int[] array)
        {
            // Write your code here.

            //Check if the length of array is greater than zero
            if (array.Length < 2)
            {
                return -1;
            }
            int start = 0;
            int next = start + 1;
            int minimumValue = int.MaxValue;

            while (start <= array.Length - 2)
            {
                //There exist duplicate value
                if (array[start] == array[next])
                {
                    minimumValue = Math.Min(minimumValue, next);
                }
                if (next == array.Length - 1)
                {
                    start++;
                    next = start + 1;
                }
                else
                {
                    next++;
                }
            }
            return minimumValue != -1 ? array[minimumValue] : -1;
        }
        #endregion

        #region FourNumberSum
        public List<int[]> FourNumberSum(int[] array, int targetSum)
        {
            //Write down your code here

            //Declare variables
            List<int[]> addSum = new List<int[]>();
            int start = 0;
            int secondPointer = start + 1;
            int thirdPointer = secondPointer + 1;
            int fourthPointer = thirdPointer + 1;

            while (start <= array.Length - 4)
            {
                //Get the sum of the values
                int sum = array[start] + array[secondPointer] + array[thirdPointer] + array[fourthPointer];

                //compare the sum and target sum. If sum is equal to targetSum, then add the numbers in the list array
                if (sum == targetSum)
                {
                    addSum.Add(new int[] { array[start], array[secondPointer], array[thirdPointer], array[fourthPointer] });
                }

                //If the fourthPointer has reached the end of the array, increase the thirdPointer
                if (fourthPointer == array.Length - 1 && thirdPointer != array.Length - 2)
                {
                    thirdPointer++;
                    fourthPointer = thirdPointer + 1;
                }
                //If the thirdPointer has reached the end of the array - 2, increase subsequent pointers
                else if (thirdPointer == array.Length - 2 && secondPointer != array.Length - 3)
                {
                    secondPointer++;
                    thirdPointer = secondPointer + 1;
                    fourthPointer = thirdPointer + 1;
                }
                //If the secondPointer has reached the end of the array - 3, increase the subsequent pointers
                else if (secondPointer == array.Length - 3)
                {
                    start++;
                    secondPointer = start + 1;
                    thirdPointer = secondPointer + 1;
                    fourthPointer = thirdPointer + 1;
                }
                //If the fourthPointer has not reached the end of the array, increase the fourthPointer
                else
                {
                    fourthPointer++;
                }
            }
            return addSum;
        }
        #endregion

        #region ArrayOfProducts
        public int[] ArrayOfProducts(int[] array)
        {
            // Write your code here.
            if (array.Length < 2)
            {
                return new int[] { };
            }

            int output = 1;
            int start = 0;
            int tracker = 0;
            int[] result = new int[array.Length];

            while (start < array.Length)
            {
                if (start != tracker)
                {
                    output *= array[tracker];
                }

                if (tracker == array.Length - 1)
                {
                    result[start] = output;
                    tracker = 0;
                    start++;
                    output = 1;
                }
                else
                {
                    tracker++;
                }
            }
            return result;
        }
        #endregion

        #region SubArraySort
        public static int[] SubarraySort(int[] array)
        {
            // Write your code here.
            int i = 0;
            int[] result = new int[] { int.MaxValue, int.MinValue };
            bool tracker = false;

            while (i <= array.Length - 2)
            {
                if (array[i] > array[i + 1])
                {
                    result = GetMinMaxSubArrayIndices(result[0], result[1], array, i);
                    tracker = true;
                }
                i++;
            }

            if (!tracker)
            {
                return new int[] { -1, -1 };
            }

            //Get Left Index
            i = 0;
            while (i < array.Length)
            {
                if (array[i] <= result[0])
                    i++;
                else
                    break;

            }
            result[0] = i;
            i = array.Length - 1;

            //Get Right index
            while (i > 0)
            {
                if (array[i] >= result[1])
                {
                    i--;
                }
                else
                {
                    break;
                }
            }
            result[1] = i;
            return result;
        }
        #endregion
        public static int[] GetMinMaxSubArrayIndices(int minimumSubArray, int maximumSubArray, int[] array, int index)
        {
            minimumSubArray = Math.Min(minimumSubArray, array[index + 1]);
            maximumSubArray = Math.Max(maximumSubArray, array[index]);
            return new int[] { minimumSubArray, maximumSubArray };
        }

        #region LargestSum
        public static int[] LargestRange(int[] array)
        {
            // Write your code here.
            //Check if the length of the array is less than 1
            if (array.Length < 1)
            {
                return new int[] { };
            }

            Array.Sort(array);
            int[] result = new int[2] { array[0], array[1] };
            HashSet<int> rangeSet = new HashSet<int>(array);
            array = rangeSet.ToArray();

            if (array.Length < 2)
            {
                return result;
            }

            int currentElement = array[0];
            int currentLength = array[0] - array[1];
            int i = 0;
            while(i < array.Length - 1)
            {
                if(array[i] + 1 == array[i + 1])
                {
                    i++;
                    continue;
                }
                else
                {
                    //Update the current length and as well, range values
                    if(array[i] - currentElement > currentLength)
                    {
                        currentLength = array[i] - currentElement;
                        result[0] = currentElement;
                        result[1] = array[i];
                        currentElement = array[i+ 1];
                    }
                    i++;
                }
            }
            if (array[i] - currentElement > currentLength)
            {
                currentLength = array[i] - currentElement;
                result[0] = currentElement;
                result[1] = array[i];
            }

            return result;
        }
        #endregion
    }
}


