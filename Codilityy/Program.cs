using System;
using System.Text;
using Sorting;
using StackImplementation;
using Recursion;
using Searching;
using System.Collections.Generic;
using System.Linq;

namespace Codilityy
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadLine();
        }

       
    }
    public class Factorial
    {
        StringBuilder sb = new StringBuilder();
        public double GetFact(double num)
        {
            sb.Append($"{num}! ");
            if (num == 1 || num == 0)
            {
                Console.WriteLine(sb);
                return num == 1 ? 1 : 0;
            }
            return num * GetFact(num - 1);
        }
    }
}
