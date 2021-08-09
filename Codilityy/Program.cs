using System;
using System.Text;
using Sorting;
using StackImplementation;
using Recursion;
using Searching;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using LeetCode;
using System.Text.RegularExpressions;

namespace Codilityy
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BreadthFirstSearch breadthFirstSearch = new BreadthFirstSearch();
            var direct = breadthFirstSearch.ConvertToDirect();
            Dictionary<string, string[]> keyValuePairs = new Dictionary<string, string[]>();
            keyValuePairs.Add("f", new string[] { });
            keyValuePairs.Add("e", new string[] { });
            keyValuePairs.Add("d", new string[] { "f" });
            keyValuePairs.Add("c", new string[] { "e" });
            keyValuePairs.Add("b", new string[] { "d" });
            keyValuePairs.Add("a", new string[] { "b", "c" });

            breadthFirstSearch.BFS(keyValuePairs, "a");
            int[] duplicates = new int[3] { 1, 1, 2 };
            RemoveDuplicatesSortedArray array = new RemoveDuplicatesSortedArray();
            var output = array.ReoveDuplicates(duplicates);
            Console.WriteLine(output);
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
        //public int solution(string S)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    List<int> largestNumber = new List<int>();
        //    char[] charsToTrim = { '.', ',', '?', '!' };
            

        //    foreach (var word in S.TrimEnd(charsToTrim).Split(charsToTrim, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        string newWprd = Regex.Replace(word, @"\s+", " ");
        //        largestNumber.Add(newWprd.ToUpper().Trim().Split(' ').Count());
        //    }
            

        //    return largestNumber.Max();
        //}

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
