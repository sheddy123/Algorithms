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
using LINQ;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Codilityy
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            Console.ReadLine();
        }
       public static Person[] ReadPeopleFromJsonFile()
        {
            using (var reader = new StreamReader(("people.json")))
            {
                string jsonData = reader.ReadToEnd();
                var people = JsonConvert.DeserializeObject<Person[]>(jsonData);
                return people;
            }
        } 
        public int solution(int[] A, int[] B, int[] C)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int track = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= C[track] && C[track] <= B[i])
                {
                    track++;
                }if(A[i] >= C[track])
                {
                    track++;
                }
            }

            return track == 0 ? 1 : (track + 1);

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
