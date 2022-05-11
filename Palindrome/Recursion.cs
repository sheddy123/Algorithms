using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion
{
    public class Recursion
    {
        public int Fibonacci(int n, Dictionary<int, int> memoObj)
        {
            if (memoObj.ContainsKey(n))
                return memoObj[n];
            
            if (n <= 2)
                return 1;

            memoObj[n] = Fibonacci(n - 1, memoObj) + Fibonacci(n - 2, memoObj);

            return memoObj[n];
        }

        public int GridTraveller(int n, int m, Dictionary<string, int> memoObj)
        {
            var key = n + " " + m;
            
            if (memoObj.ContainsKey(key))
                return memoObj[key];

            if (n == 1 && m == 1)
                return 1;

            if (n == 0 || m == 0)
                return 0;

            memoObj[key] = GridTraveller(n - 1, m, memoObj) + GridTraveller(n, m - 1, memoObj);
            return memoObj[key];
        }
        public static int count = 0;
        public static bool hasTraversed = false;
        public bool CanSum(int[] array, int targetSum, int tracker)
        {
            if (count == 0 && !hasTraversed)
            {
                count = array.Length - 1;
                hasTraversed = true;
            }

            if (array.Length < 1)
                return false;

            int difference = Math.Abs(targetSum - array[tracker]);

            if (array.ToList().Contains(difference))
                return true;

            return CanSum(array, targetSum, count--);
        }
    }
}
