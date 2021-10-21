using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class MostCommon
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = Regex.Replace(paragraph, @"[^\w\s]", "");
            string[] arr = paragraph.Split(' ');
            HashSet<string> bannedCollectios = new HashSet<string>(banned.Select(s => s.ToLowerInvariant()));
            int i = 0;
            int j = arr.Length - 1;

            if (banned.Length == 0)
                return paragraph.ToLower();

            while (i <= j && ((i+1) <arr.Length - 1))
            {
                if ((i) == j)
                {
                    i++;
                    j = arr.Length - 1;
                }

                if (i <= arr.Length)
                {
                    if (arr[i].ToLower() == arr[j].ToLower() && banned.Length > 0)
                    {
                        if (!bannedCollectios.Contains(arr[i].ToLower()))
                            return arr[i].ToLower();
                        //if (arr[i].ToLower() != banned[0].ToLower())
                        //return arr[i].ToLower();
                        else
                            j--;

                    }
                    else
                        j--;
                }
            }
            return paragraph;
        }
    }
}

