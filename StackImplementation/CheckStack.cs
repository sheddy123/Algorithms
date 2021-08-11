namespace StackImplementation
{
    public class CheckStack
    {
        public string ReverseString2(string input)
        {
            if (input.Length < 0) return "";

           System.Collections.Generic.Stack<string> stackInput = new System.Collections.Generic.Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                stackInput.Push(input[i].ToString());
            }
            string reversedString = "";
            foreach(var item in stackInput){
                reversedString += item;
            }
            return reversedString;
        }
    }
}
