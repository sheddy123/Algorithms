using System;
namespace Codilityy
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int a = 1; a <= K; a++)
            {
                int i = 0;
                var t = A;
               
                int temp = A[A.Length - 1];
                while (i < A.Length)
                {
                    if (i == A.Length - 1)
                    {
                        A[0] = temp;break;
                    }
                    else
                    {
                        A[A.Length - (i + 1)] = A[A.Length - (i + 2)];
                    }
                    i++;
                }
              
            }
            return A;
        }
    }

}
