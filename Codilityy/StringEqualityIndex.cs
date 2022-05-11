namespace Codilityy
{
    public class StringEqualityIndex
    {
        private int[] ThereExistPair(int startIndex, int nextIndex, string[] S)
        {
            //Run the loop while startIndex is less than the length of the string array by 1
            while (startIndex < S.Length - 1)
            {
                //Get the current word in the string array
                string currentWord = S[startIndex];
                //Get the next word in the string array
                string nextWord = S[nextIndex];

                //loop through the words to compare the characters between currentWord and nextWord
                for (int i = 0; i < currentWord.Length; i++)
                {
                    //if the characters between the two words are the same, return their
                    //respective positions in the array alongside the index of the similar word
                    if (currentWord[i] == nextWord[i])
                    {
                        return new int[3] { startIndex, nextIndex, i };
                    }
                }
                nextIndex++;

                //if the value of nextIndex is equal to the length of the string array,
                //increase the value of startIndex and set nextIndex to startIndex + 1
                if (nextIndex == S.Length)
                {
                    startIndex++;
                    nextIndex = startIndex + 1;
                }
            }
            //return an empty array, if there doesn't exist a pair of strings that fulfils the criteria
            return new int[] { };
        }
        public int[] solution(string[] S)
        {
            //Checks if the length of the string is 1 or less than,
            //in such scenario there won't be any need to compare values as no other index(es) exist
            //therefore we return an empty array.
            if(S.Length < 2)
            {
                return new int[] { };
            }

            //Get the first index in the string array
            int startIndex = 0;
            //Get the next index in the string array
            int nextIndex = startIndex + 1;

            //Solution 2
            //int[] result = ThereExistPair(startIndex, nextIndex, S);
            //return result;


            //Run the loop while startIndex is less than the length of the string array by 1
            while (startIndex < S.Length - 1)
            {
                //Get the current word in the string array
                string currentWord = S[startIndex];
                //Get the next word in the string array
                string nextWord = S[nextIndex];
                
                //loop through the words to compare the characters between currentWord and nextWord
                for(int i=0; i<currentWord.Length; i++)
                {
                    //if the characters between the two words are the same, return their
                    //respective positions in the array alongside the index of the similar word
                    if(currentWord[i] == nextWord[i])
                    {
                        return new int[3] { startIndex, nextIndex, i };
                    }
                }
                nextIndex++;

                //if the value of nextIndex is equal to the length of the string array,
                //increase the value of startIndex and set nextIndex to startIndex + 1
                if(nextIndex == S.Length)
                {
                    startIndex++;
                    nextIndex = startIndex + 1;
                }
            }
            //return an empty array, if there doesn't exist a pair of strings that fulfils the criteria
            return new int[] { };
        }
    }

}
