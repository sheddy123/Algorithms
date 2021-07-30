using System;
using System.Text;
using Sorting;
using StackImplementation;
using Recursion;
using Searching;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Codilityy
{
    class Program
    {
        static void Main(string[] args)
        {
            AdditionOfNumbers addNumbers = new AdditionOfNumbers();
            int totalNumbers = addNumbers.AddTotalNumbers(5);
            int totalNumbers2 = addNumbers.AddTotalNumbers2(5);
            Console.WriteLine($"Addition with first calculation = {totalNumbers}");
            Console.WriteLine($"Addition with second calculation = {totalNumbers2}");

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
