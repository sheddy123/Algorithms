using System.Text.RegularExpressions;

namespace LeetCode
{
    public class MostCommon
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = Regex.Replace(paragraph, @"[^\w\s]", "");
            string[] arr = paragraph.Split(' ');
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                if ((i + 1) == j)
                {
                    i++;
                    j = arr.Length - 1;
                }

                if (arr[i].ToLower() == arr[j].ToLower() && banned.Length > 0)
                {
                    if (arr[i].ToLower() != banned[0].ToLower())
                        return arr[i].ToLower();
                    else
                        j--;
                    
                }
                else
                    j--;

            }
            return paragraph;
        }
    }
}

