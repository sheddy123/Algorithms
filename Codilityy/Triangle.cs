using System;

namespace Codilityy
{
    public class Triangle
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        int check1 = A[i] + A[j];
                        int check2 = A[j] + A[k];
                        int check3 = A[k] + A[i];
                        if (check1 > A[k] && check2 > A[i] && check3 > A[j])
                        {
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
