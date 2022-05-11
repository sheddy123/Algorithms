using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codilityy
{
    public class MissingInteger
    {
        public int GetMissingInteger(int[] A)
        {
            HashSet<int> foundNumber = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    foundNumber.Add(A[i]);
                }
            }


            int result = 1;
            while (foundNumber.Contains(result))
            {
                result++;
            }
            return result;
        }
        public int[] solution(string[] S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (S.Length < 1)
                return new List<int>().ToArray();
            HashSet<int> addValues = new HashSet<int>();
            //int k = 0;
            for (int i = 0; i < S.Length - 1; i++)
            {
                 
                var stringToCheck = S[i].ToLower();
                //var nextStringToCheck = S[(i + 1)].ToLower();
                for (int j = i + 1; j < S.Length; j++)
                {
                    string nextVal = S[(j)].ToLower();
                   
                        for(int k=0; k < nextVal.Length; k++)
                        {
                            if(stringToCheck[k] == nextVal[k])
                            {
                            addValues.Add(i);
                            addValues.Add(j);
                            addValues.Add(k);
                                
                            }
                        }
                    
                }
            }
            return addValues.ToArray();
            
        }
        // solution function implementation
        public static int solution(int[] arr)
        {
            // declare the local variables
            int i, j, count = 0; bool shines;
            // use the nested loops to count the number of moments for which every turned on bulb shines  

            for (i = 0; i < arr.Length; i++) 
            { 
                shines = true; 
                for (j = i + 1; j < arr.Length && shines; j++) 
                { 
                    if (arr[i] > arr[j]) shines = false; 
                } 
                if (shines) count++; 
            }
            return count;
        }

    }

}


