using System;
using System.Collections.Generic;
using System.Linq;

namespace Codilityy
{
    public class MissingInteger
    {
        public int GetMissingInteger(int[] A)
        {
            HashSet<int> foundNumber = new HashSet<int>();
            for(int i=0; i<A.Length; i++)
            {
                if(A[i] > 0)
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
    }

}
