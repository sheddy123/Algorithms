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
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            return array.Skip(offset)
                        .Take(length)
                        .ToArray();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Dictionary<int, string> addSub = new Dictionary<int, string>();
            for (int i = 0; i < 9; i++)
            {
                int offset = 1;
                int length = i;
                var d = String.Join(",", array);
                var dg = array.SubArray(offset, length);
                Console.WriteLine(String.Join(",", dg));
            }
            //Dictionary<int, string> addTestScores = new Dictionary<int, string>();
            //string[] tests = new string[] { "testCaseName1", "testCaseName1a", "testCaseName2", "testCaseName3", "testCaseName4"};
            //int c = 0;
            //foreach(var test in tests)
            //{
            //    string regEx = System.Text.RegularExpressions.Regex.Match(test, @"\d+").Value;
            //    var index = test.IndexOf(regEx);
            //    var testCaseName = test.Substring(0, index + 1);
            //    addTestScores.Add(c, regEx);
            //    c++;
            //}
            //MissingInteger sort = new MissingInteger();
            //var A = new string[4] { "zzzz", "ferz", "zdsr","fgtd" };
            //var sol = sort.solution(A);
            //int[] arrayTest = new int[8] { 12, 18, 15, 21, 19, 30, 4, 17};
            // var ss = selectionSort.Selection(arrayTest);
            int[] arr = new int[3] { 1, 2, 3 };
            HashSet<int> add = new HashSet<int>(arr);
            add.ToArray();
          //  add.Remove()
            int counter = 0;
           var item =  Math.Abs(-1); 
            List<int> addOps = new List<int>(arr);
            List<int> addElements = new List<int>();
            for(int i=0; i< addOps.Count; i++)
            {
                int checkValueExist = addOps[i] + 1;
                if (addOps.Contains(checkValueExist))
                {
                    counter = counter + 1;
                    addElements.Add(counter);
                }
            }
            
            var expected = addElements.Count > 0 ? addElements[0] : 0;
           // string[] ops = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
           // List<string> addOps = new List<string>(ops);
           // List<string> addElements = new List<string>();
           // for (int i = 0; i < addOps.Count; i++)
           // {
           //     switch (addOps[i])
           //     {
           //         case "+":
           //             var lastTwoItemsSum = Convert.ToInt32(addElements[(addElements.Count - 1)]) + Convert.ToInt32(addElements[(addElements.Count - 2)]);
           //             addElements.Add(lastTwoItemsSum.ToString()); break;
           //         case "D":
           //             var result = Convert.ToInt32(addElements[(addElements.Count - 1)]) * 2;
           //             addElements.Add(result.ToString());
           //             break;
           //         case "C": addElements.RemoveAt(Convert.ToInt32(addElements.Count - 1)); break;
           //         default: addElements.Add(addOps[i]); break;
           //     }
           // }
           //var sum = addElements.Sum(x => Convert.ToInt32(x));
            
           // var stringArray = addElements.ToArray();
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
                }
                if (A[i] >= C[track])
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
