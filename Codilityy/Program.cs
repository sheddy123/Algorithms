using System;
using System.Text;
using Sorting;
using StackImplementation;
using Recursion;
using Searching;

namespace Codilityy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8] { 30, 3, 14, 5, 6, 8, 2, 71 };
            InsertionSort sort = new InsertionSort();
            sort.Insert_Sort(array);
            BinarySearch binSearch = new BinarySearch();
            StringBuilder sb = new StringBuilder();
            foreach(var val in array)
            {
                sb.Append(val);
            }
            Console.WriteLine(sb.ToString());
            var num = binSearch.BinarySearchImp(array, 0, array.Length -1, 8);
            Console.WriteLine("The index fell at index " + num);
            //string palindromeWord = "sasdrqdsas";

            //Palindrome _Palindrome = new Palindrome(palindromeWord);
            //var isPalindrome = _Palindrome.IsPalindrome(palindromeWord.Length);
            //Console.WriteLine(isPalindrome);

            //            string word = "abcdefghijklmnpqrstuvwxyz";


            //WordReversal reverse = new WordReversal(word);
            //var reversedWord = reverse.reverseString(word);
            //Console.WriteLine($"Before reversal: {word} \n\t\n ");

            //Console.WriteLine($"After reversal: {reversedWord} \n\t\n ");



            //Stack stackImplementation = new Stack(-1);
            //var isEmpty = stackImplementation.IsEmpty();
            //stackImplementation.Push(4);
            //Console.WriteLine(isEmpty);
            //InsertionSort sort = new InsertionSort();
            //sort.Insert_Sort(array);
            //foreach (var item in array)
            //    Console.WriteLine(item);

            //BubbleSort sort = new BubbleSort();

            //sort.SortBubble(array);
            //foreach (var item in array)
            //    Console.WriteLine(item);
            //Hash_Examples hash_Examples = new Hash_Examples();
            //var getPhone = hash_Examples.PhoneNumbers();
            //foreach (var phone in getPhone)
            //{
            //    Console.WriteLine(phone);
            //}
            //int[] array = new int[8] { 30, 3, 14, 5, 6, 8, 2, 71 };

            //sorting.QuickSort(array, 0, array.Length - 1);

            //foreach(var i in array)
            //{
            //    Console.WriteLine($"\n\n{i},");
            //}
            //double num = Console.Read();
            //Console.WriteLine(fact.GetFact(num));
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
