using System;
using System.Text;
using Sorting;


namespace Codilityy
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash_Examples hash_Examples = new Hash_Examples();
            var getPhone = hash_Examples.PhoneNumbers();
            foreach (var phone in getPhone)
            {
                Console.WriteLine(phone);
            }
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
