using System.Collections.Generic;
namespace Codilityy
{
    public class ArithmeticMean
    {
        public int solution(int[] A, int S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int output = 0; int sum = 0; int arrayLength = A.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                sum = 0;
                for (int j = i; j < arrayLength; j++)
                {
                    sum = sum + A[j];

                    //get different sizes of length
                    int length = (j - i + 1);

                    //checks if the sum is a whole number in order to determine if
                    //the average will be equal S.

                    if (sum % length == 0)
                    {
                        int average = sum / length;
                        if (average == S)
                        {
                            //Increases the number of contiguous fragments
                            output++;
                        }
                    }
                }
            }
            return output;
        }

        public int AMean(int[] A, int fragment)
        {
            if (A == null)
                return 0;
            if(A!= null && A.Length <=0)
            {
                if (A[0] == fragment)
                    return fragment;
                return 0;
            }
            int sum = A[0];
            int i = 0; int j = i; int count = 0;
            while (i <= j)
            {
                sum = i==j ? A[i] : sum + A[j];
                int length = j - i + 1;

                if(sum % length == 0)
                {
                    int arithmeticMean = sum / length;
                    
                    if (arithmeticMean == fragment)
                        count++;
                    
                }
                if (j == A.Length - 1)
                {
                    i++;
                    j = i;
                    sum = 0;
                }
                else
                    j++;


                if (i == A.Length - 1)
                    break;
                
            }
            return count;
        }
    }
}



