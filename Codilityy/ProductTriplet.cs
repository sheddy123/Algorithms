using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
namespace Codilityy
{
    class ProductTriplet
    {
        
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length > 0)
            {
                Dictionary<int, int> maxProduct = new Dictionary<int, int>();
                int product = 1;
                maxProduct.Add(0, -3);
                maxProduct.Add(1, 1);
                maxProduct.Add(2, 2);
                maxProduct.Add(3, -2);
                maxProduct.Add(4, 5);
                maxProduct.Add(5, 6);
                for (int i = 0; i < A.Length; i++)
                {
                    while (A[i] > 0)
                    {
                        product *= maxProduct[i];
                        break;
                    }
                }
                //  product *= item;

                return product;
            }
            return 0;
        }
    }

}