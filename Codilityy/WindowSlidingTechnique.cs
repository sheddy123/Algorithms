using System;

namespace Codilityy
{
    public class WindowSlidingTechnique
    {
        public int MaxItem(int[] arr, int n, int k)
        {
            // Initialize result
            int max_sum = int.MinValue;

            // Consider all blocks starting
            // with i.
            for (int i = 0; i < n - k + 1; i++)
            {
                var dd = n - k + 1;
                int current_sum = 0;
                for (int j = 0; j < k; j++)
                    current_sum = current_sum + arr[i + j];

                // Update result if required.
                max_sum = Math.Max(current_sum, max_sum);
            }

            return max_sum;
        }
        public static int maxSum(int[] arr, int n, int k)
        {

            // n must be greater
            if (n < k)
            {
                Console.WriteLine("Invalid");
                return -1;
            }

            // Compute sum of first window of size k
            int max_sum = 0;
            for (int i = 0; i < k; i++)
                max_sum += arr[i];

            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.
            int window_sum = max_sum;
            for (int i = k; i < n; i++)
            {
                window_sum += arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }

            return max_sum;
        }

        public int SlideMaxItem(int[] arr, int n, int k)
        {
            int max_Sum = 0;
            int windowSum = 0;
            for (int i = 0; i < k; i++)
            {
                windowSum += arr[i];
            }
            max_Sum = windowSum;
            for(int i=k; i<n; i++)
            {
                var dd = arr[k];
                var df = windowSum;
                var sdf = arr[i - k];
                var sj = arr[i] - arr[i - k];
                windowSum += arr[i] - arr[i - k];
                max_Sum = Math.Max(max_Sum, windowSum);
            }
            return max_Sum;
        }
    }
}
