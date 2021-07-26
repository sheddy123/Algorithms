namespace Codilityy
{
    public class AdditionOfNumbers
    {
        public int AddTotalNumbers(int n)//Approach 1
        {
            int result = 0;
            result = (n * (n + 1))/2;
            return result;
        }
        //1+2+3+4+5
        public int AddTotalNumbers2(int n)
        {
            int result = 0;
            for(int i=0; i<=n; i++)
            {
                result += i; 
            }
            return result;
        }
    }
}
