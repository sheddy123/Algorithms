using System;
namespace Codilityy
{
    public class MaxProductOfThree
    {
        public int solution(int[] sortedArray)
        {
            Array.Sort(sortedArray);
            int length = sortedArray.Length;
            int P, Q, R;
            int maximumLeft = int.MinValue, maximumRight = int.MaxValue;

            P = sortedArray[length - 3];
            Q = sortedArray[length - 2];
            R = sortedArray[length - 1];
            maximumRight = P * Q * R;

            P = sortedArray[0];
            Q = sortedArray[1];
            R = sortedArray[length - 1];

            maximumLeft = P * Q * R;


            return maximumRight > maximumLeft ? maximumRight : maximumLeft;
        }

    }
}
