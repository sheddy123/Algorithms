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

        public string ReverseWord()
        {
            var word = input.ToCharArray();
            StackWord stackWord = new StackWord(word.Length);
            int length = word.Length;
            for(int i = 0; i<word.Length; i++)
            {
                stackWord.Push(word[i]);
            }
            output = "";
            while(length > 0)
            {
                output += stackWord.Pop().ToString();
                length--;
            }
            return output;
        }

        public string reverseString(string input)
        {
            if (input == "")
            {
                return "";
            }
            return reverseString(input.Substring(1)) + input[0];
        }

       
    }
}
