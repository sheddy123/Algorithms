﻿namespace StackImplementation
{
    public class AlgoExpertRecursion
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
