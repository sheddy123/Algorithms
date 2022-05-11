using System.Collections.Generic;

namespace StackImplementation
{
    public class AlgoExpertDynamicProgramming
    {
        public static int NthFibonacciNumber(int n, List<int> containsValueSet)
        {
            if (containsValueSet.Contains(n))
                return containsValueSet[n];
            if (n <= 2)
                return 1;

            return NthFibonacciNumber(n - 1, containsValueSet) + NthFibonacciNumber(n - 2, containsValueSet);
        }
    }
}
