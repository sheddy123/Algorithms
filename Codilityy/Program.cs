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
using CrackingCodingInterview;
using static CrackingCodingInterview.LinkedListImplementation;

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
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            List<int[]> addThreeSum = new List<int[]>();
            int start = 0;
            int middle = start + 1;
            int end = array.Length - 1;
            while (start + 2 <= array.Length - 1)
            {
                int threeSum = array[start] + array[middle] + array[end];

                if (threeSum == targetSum)
                {
                    int[] newArray = new int[3] { array[start], array[middle], array[end] };
                    Array.Sort(newArray);
                    addThreeSum.Add(newArray);
                }
                if ((start + 2 == array.Length - 1) && (middle + 1 == array.Length - 1) && end == array.Length - 1)
                {
                    break;
                }
                //if middle is in the second to last index of array, increment [start], [middle] and set [end] back to (length of array - 1)
                if (middle + 1 == array.Length - 1)
                {
                    start = start + 1;
                    middle = start + 1;
                    end = array.Length - 1;
                }

                //if the end pointer is a step ahead of middle, increase [middle] and set [end] back to (length of array - 1);
                else if (middle == end - 1 && middle + 1 != array.Length - 1)
                {
                    middle = middle + 1;
                    end = array.Length - 1;
                }
                else if (middle + 1 != array.Length - 1)
                {
                    end--;
                }


            }
            if (addThreeSum.Count > 0)
            {
                var result = from x in addThreeSum
                             orderby x[0] ascending,
                             x[1] ascending
                             select x;
                return result.ToList();
            }
            return new List<int[]>();
        }
    }

    class Program
    {
        public static void RemoveKthNodeFromEnd(LinkedList head, int k)
        {
            // Write your code here.

            head = ReverseNodes(head);
            LinkedList current = head;
            LinkedList temp2;
            for (int i = 0; i <= k; i++)
            {
                if (i == k - 2)
                {
                    temp2 = current.Next.Next;
                    current.Next = null;
                    current.Next = temp2;
                    break;
                }
                current = current.Next;
            }

            head = ReverseNodes(head);
        }
        public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {

            linkedListOne = ReverseNodes(linkedListOne);
            string firstSum = Sum(linkedListOne);
            linkedListTwo = ReverseNodes(linkedListTwo);
            string secondSum = Sum(linkedListTwo);
            int totalSum = Convert.ToInt32(firstSum) + Convert.ToInt32(secondSum);

            LinkedList sum = null;// new LinkedList(totalSum);


            if (sum == null)
            {
                var nu = totalSum.ToString();
                sum = new LinkedList(Convert.ToInt32(nu[0].ToString()));
                int i = 1;
                var tem = sum;
                while (i < nu.Length)
                {
                    tem.Next = new LinkedList(Convert.ToInt32(nu[i].ToString()));
                    tem = tem.Next;
                    i++;
                }
            }

            sum = ReverseNodes(sum);

            return sum;
        }
        public string Sum(LinkedList link)
        {
            if (link == null)
            {
                return "";
            }
            string count = "";
            LinkedList current = link;
            while (current != null)
            {
                count += current.Value;
                current = current.Next;
            }
            return count;
        }
        public static LinkedList mergeLinkedLists(LinkedList headOne, LinkedList headTwo)
        {
            // Write your code here.
            int var1 = headOne.Value;
            int var2 = headTwo.Value;
            int temp1 = var1;
            int temp2 = var2;
            LinkedList tail;
            if (var1 < var2)
            {
                tail = headOne;
            }
            else
            {
                tail = headTwo;
            }

            LinkedList current1 = var1 < var2 ? headOne.Next : headOne;
            LinkedList current2 = var1 > var2 ? headTwo.Next : headTwo;


            while (current1 != null && current2 != null)
            {
                var1 = current1.Value;
                var2 = current2.Value;
                if (var1 < var2)
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                else
                {
                    tail.Next = current2;
                    current2 = current2.Next;
                }
                tail = tail.Next;
            }

            if (current1 != null)
            {
                tail.Next = current1;
            }
            if (current2 != null)
            {
                tail.Next = current2;
            }
            return temp1 < temp2 ? headOne : headTwo;
        }
        public static LinkedList ReverseNodes(LinkedList head)
        {
            LinkedList node = head;
            LinkedList previous = null;

            while (node != null)
            {
                LinkedList current = node.Next;
                node.Next = previous;
                previous = node;
                node = current;
            }
            head = previous;
            return head;
        }
        public class LinkedList
        {
            public int Value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.Value = value;
            }
        }
        public LinkedList NodeSwap(LinkedList head)
        {
            LinkedList current = head;
            LinkedList nxtPointer = current.Next;
            LinkedList newHead = nxtPointer;
            LinkedList previous = null;
            /* 2-3-4-5-6-7-7
             * 3-4-5-6-7-7
             * 5
             * i = 2, j = 4;
             * int temp = i;
             * i = j;
             * j = temp;
             * temp = current;
             * temp2= current.next;
             * current.next = temp;
             * current = temp2;
             * current = current.next.next;
            */
            while (current != null)
            {
                current.Next = nxtPointer.Next;
                nxtPointer.Next = current;
                if (previous != null)
                    previous.Next = nxtPointer;
                previous = current;
                current = current.Next;
                if (current != null)
                    nxtPointer = current.Next;
            }
            return newHead;
        }
        public LinkedList ZipLinkedList(LinkedList linkedList)
        {
            // Write your code here.

            LinkedList list1 = Program.ReverseNodes(linkedList);
            LinkedList current = list1;
            string nodes = "";
            while (current != null)
            {
                nodes += current.Value;
                current = current.Next;
            }
            int length = nodes.Length - 1;
            LinkedList list2 = new LinkedList(Convert.ToInt32(nodes[length].ToString()));
            LinkedList track = list2;
            while (length > 0)
            {
                length--;
                var ds = nodes[length].ToString();
                track.Next = new LinkedList(Convert.ToInt32(ds));
                track = track.Next;
            }



            LinkedList tail = list2;
            LinkedList current1 = list1;
            LinkedList current2 = list2.Next;
            int count = 1;

            while (current1 != null && current2 != null)
            {
                if (count % 2 == 0)
                {
                    tail.Next = current2;
                    current2 = current2.Next;
                }
                else
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                tail = tail.Next;
                count += 1;
            }
            if (current1 != null)
            {
                tail.Next = current1;
            }
            if (current2 != null)
            {
                tail.Next = current2;
            }
            return list2;
        }


        private static string ReverseString(string _stringToReverse)
        {

            if (string.IsNullOrEmpty(_stringToReverse))
            {
                return null;
            }
            int start = 0;
            int end = _stringToReverse.Length - 1;
            StringBuilder newReversedString = new StringBuilder();
            while (start <= end)
            {
                newReversedString.Append(_stringToReverse[end]);
                end--;
            }
            return newReversedString.ToString();
        }

        private static bool BinarySearch(int[] arrayNumbers, int numToFind)
        {
            if (arrayNumbers.Length < 0)
                return false;
            Array.Sort(arrayNumbers);
            int min = 0;
            int max = arrayNumbers.Length - 1;
            while (min < max)
            {
                int mid = min + max / 2;
                if (arrayNumbers[mid] == numToFind)
                    return true;
                //check left side
                if (numToFind < mid)
                {
                    max = mid - 1;
                }

                //check right side
                if (numToFind > mid)
                {
                    max = mid + 1;
                }
            }
            return false;
        }
        public class CardCost
        {
            public int CostType { get; set; }
            public decimal Amount { get; set; }
            public int IndexOnList { get; set; }
            public int fillMissingBrackets(string s)
            {
                //We'll check if brackets are balanced first before getting the number of ways it can
                //be split into two non-empty substrings

                if (s.Length % 2 != 0)
                {
                    return 0;
                }


                bool bracketsAreBalanced = BracketsAreBalanced(s);
                if (!bracketsAreBalanced)
                {
                    return 0;
                }

                Stack<char> bracketStack = new Stack<char>();
                foreach (var bracket in s)
                {

                    if ((bracket == ']' || bracket == ')' || bracket == '?') && bracketStack.Count > 0)
                    {
                        if ((bracketStack.Peek() == '[' || bracketStack.Peek() == '('))
                        {
                            bracketStack.Pop();
                        }
                        else
                        {
                            if (bracket == '?' && 1 > bracketStack.Count)
                            {

                            }
                            {
                                if (bracketStack.Peek() == '(')
                                {

                                }
                            }
                            bracketStack.Push(bracket);
                        }
                    }
                    else
                    {
                        bracketStack.Push(bracket);
                    }
                }
                int red_len = bracketStack.Count;
                int n = 0;

                while (bracketStack.Count > 0 && (bracketStack.Peek() == '[' || bracketStack.Peek() == '('))
                {
                    bracketStack.Pop();
                    n++;
                }
                int result = red_len / 2 + (n % 2);

                return (result);
            }

            public static bool BracketsAreBalanced(string input)
            {
                input = input.Replace("?", "");
                Stack<char> inputStack = new Stack<char>();
                foreach (var bracket in input)
                {
                    if (bracket == '[' || bracket == '(')
                    {
                        inputStack.Push(bracket);
                    }
                    if (bracket == ']' || bracket == ')')
                    {
                        if (inputStack.Count == 0)
                        {
                            return false;
                        }
                        else if (!isMatchingPair(inputStack.Pop(), bracket))
                        {
                            return false;
                        }
                    }
                }
                if (inputStack.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool isMatchingPair(char character1, char character2)
            {
                if (character1 == '(' && character2 == ')')
                {
                    return true;
                }
                else if (character1 == '[' && character2 == ']')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int additionOfNumbers(int number)
            {
                if (number == 1)
                {
                    return 1;
                }
                return (number % 10) + additionOfNumbers(number / 10);
            }

            public List<string> processLogs(List<string> logs, int threshold)
            {
                HashSet<string> hash = new HashSet<string>();
                List<int> duplicate = new List<int>();
                Dictionary<int, int> getTransactionTreshold = new Dictionary<int, int>();
                int currentValue = 0;
                int count = 0;
                foreach (var log in logs)
                {
                    var trimmed = logs[count].Replace(" ", "");
                    var sender_user_id = Convert.ToInt32(logs[count].Replace(" ", "")[0]);
                    var recipient_user_id = Convert.ToInt32(logs[count].Replace(" ", "")[1]);
                    if (getTransactionTreshold.ContainsKey(sender_user_id))
                    {

                        currentValue = getTransactionTreshold[sender_user_id];
                        currentValue = currentValue + 1;
                        getTransactionTreshold[sender_user_id] = currentValue;
                    }
                    else
                    {

                        getTransactionTreshold[sender_user_id] = 1;
                        duplicate.Add(sender_user_id);
                    }
                    if (sender_user_id != recipient_user_id)
                    {
                        if (getTransactionTreshold.ContainsKey(recipient_user_id))
                        {
                            currentValue = getTransactionTreshold[recipient_user_id];
                            currentValue = 0;
                            getTransactionTreshold[recipient_user_id] = currentValue;



                        }
                        else
                        {
                            getTransactionTreshold.Add(recipient_user_id, 1);


                        }
                    }
                    count++;

                }


                foreach (var val in getTransactionTreshold)
                {
                    Console.WriteLine(val.Key);
                    if (getTransactionTreshold[val.Key] >= threshold)
                    {
                        hash.Add(Convert.ToString(val.Value));
                    }
                }
                hash.ToList().Sort();

                return hash.Count > 0 ? hash.ToList() : new List<string>();
            }

        }
        //public static Node head = new Node(1);
        static void Main(string[] args)
        {

            string getSubstrings = "abaxyzzyxf";
            var sub1 = getSubstrings.Substring(0, 2);
            var sub2 = getSubstrings.Substring(9, 0);
            var sub3 = getSubstrings[9..10];
            LinkedList linkedList = new LinkedList(0);
            LinkedList linkedList2 = new LinkedList(1);
            LinkedList linkedList3 = new LinkedList(2);
            LinkedList linkedList4 = new LinkedList(3);

            LinkedList linkedList5 = new LinkedList(4);
            LinkedList linkedList6 = new LinkedList(5);
            LinkedList linkedList7 = new LinkedList(4);
            LinkedList linkedList8 = new LinkedList(5);
            LinkedList linkedList9 = new LinkedList(9);
            LinkedList linkedList0 = new LinkedList(10);

            linkedList.Next = linkedList2;
            linkedList2.Next = linkedList3;
            linkedList3.Next = linkedList4;

            linkedList4.Next = linkedList5;
            linkedList5.Next = linkedList6;
            //linkedList6.Next = linkedList7;
            linkedList7.Next = linkedList8;
            linkedList8.Next = linkedList9;
            linkedList9.Next = linkedList0;

            Program gram = new Program();
            var ressd = gram.NodeSwap(linkedList);
            Program.RemoveKthNodeFromEnd(linkedList, 1);

            LinkedListImplementation linkedListImplementation = new LinkedListImplementation();
            Node head = new Node(1);
            Node nodeB = new Node(1);
            Node nodeC = new Node(3);
            Node nodeD = new Node(4);
            Node nodeE = new Node(4);
            Node nodeF = new Node(4);
            Node nodeG = new Node(5);
            Node nodeH = new Node(6);
            Node nodeI = new Node(6);

            head.next = nodeB;
            nodeB.next = nodeC;
            nodeC.next = nodeD;
            nodeD.next = nodeE;
            nodeE.next = nodeF;
            nodeF.next = nodeG;
            nodeG.next = nodeH;
            nodeH.next = nodeI;

            linkedListImplementation.CountNodes();
            var dghd = linkedListImplementation.RemoveDuplicatesFromLinkedList(head);
            linkedListImplementation.DisplayNodes(head);
            linkedListImplementation.ReverseNodes(head);
            linkedListImplementation.InsertAtFirst(head);
            linkedListImplementation.InsertAtLast(head);
            linkedListImplementation.InsertAtKthPosition(2, head);

            CardCost cost = new CardCost();
            string test = "[(?][??[";
            var resulta = cost.fillMissingBrackets(test);

            int[] arra = new int[4] { 3, 5, 9, 8 };

            List<string> logs = new List<string>();

            logs.Add("1 2 50");
            logs.Add("1 7 70");
            logs.Add("1 3 20");
            logs.Add("2 2 17");
            var dsd = cost.processLogs(logs, 2);
            var result = cost.additionOfNumbers(1235);


            int targetSum = 0;
            int[] arrayThree = new int[11] { 12, 3, 1, 2, -6, 5, 0, -8, -1, 6, -5 };
            var output = Extensions.ThreeNumberSum(arrayThree, targetSum);


            var dd = "[{\"CostType\":0,\"Amount\":1050.0,\"IndexOnList\":0},{\"CostType\":1,\"Amount\":800.0,\"IndexOnList\":0}]";
            var dfg = JsonConvert.DeserializeObject<List<CardCost>>(dd);

            int[] numbersToSearch = { 0, 3, 4, 6, 4, 3, 21 };
            bool isNumFound = BinarySearch(numbersToSearch, 4);
            string demo = "Please reverse this string";
            Console.WriteLine(ReverseString(demo));

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
            var item = Math.Abs(-1);
            List<int> addOps = new List<int>(arr);
            List<int> addElements = new List<int>();
            for (int i = 0; i < addOps.Count; i++)
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
