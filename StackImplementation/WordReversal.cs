namespace StackImplementation
{
    public class StackWord
    {
        private int maxSize;
        private char[] word;
        private int top;

        public StackWord(int size)
        {
            maxSize = size;
            word = new char[size];
            top = -1;
        }

        //push
        public void Push(char item)
        {
            word[++top] = item;
        }

        //pop
        public char Pop()
        {
            return word[top--];
        }

        //peek
        public char Peek()
        {
            return word[top];
        }

        //isempty
        public bool IsEmpty()
        {
            return (word.Length < 0);
        }

        //isfull
        public bool IsFull()
        {
            return (top == word.Length - 1);
        }

    }
    public class WordReversal
    {
        private string input;
        private string output;
        public WordReversal(string num)
        {
            input = num;
        }
        //
        public WordReversal()
        {

        }

        public string ReverseWord()
        {
            var word = input.ToCharArray();
            StackWord stackWord = new StackWord(word.Length);
            int length = word.Length;
            for (int i = 0; i < word.Length; i++)
            {
                stackWord.Push(word[i]);
            }
            output = "";
            while (length > 0)
            {
                output += stackWord.Pop().ToString();
                length--;
            }
            return output;
        }
        public static bool IsPalindrome(string str)
        {
            // Write your code here.

            string reversedWord = ReverseWord(str);
            if (reversedWord == str)
            {
                return true;
            }
            return false;
        }

        //Create a function that reverses the string
        public static string ReverseWord(string word)
        {
            if (word == "")
            {
                return "";
            }

            return ReverseWord(word.Substring(1)) + word[0];
        }
        public string reverseString(string input)
        {
            if (input == "")
            {
                return "";
            }
            return reverseString(input.Substring(1) + input[0]);
        }
        public string reverseWords(string s)
        {
            //Your code here
            if (s.IndexOf(".") == -1)
            {
                return s;
            }


            return reverseWords(s.Substring(s.IndexOf(".") + 1)) + "." + s.Substring(0, s.IndexOf("."));
        }
        public string ReverseWordsInString(string str)
        {
            if (str.Length < 1)
            {
                return "";
            }

            str = ReverseWords(str);
            return str;
        }
        public string ReverseWords(string str)
        {
            if(str.IndexOf(" ") == -1)
            {
                return str;
            }

            return ReverseWords(str.Substring(str.IndexOf(" ") + 1)) + " " + str.Substring(0, str.IndexOf(" "));
        }
        public int[] ReverseArrayInPlace(int[] input)
        {

            for (int i = 0; i < (input.Length / 2); i++)
            {
                //store the initial string in temp variable
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
            return input;
        }

        public int[] RotateArray(int[] array)
        {
            //[6,4,2,4,5,6,3]
            //[4,2,4,5,6,3,3]
            int temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
            return array;
        }

    }
}
