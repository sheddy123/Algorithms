using System.Text.RegularExpressions;

namespace Codilityy
{
    //URLify: Write a method to replace all  spaces in  a string with '%2e: You  may assume that the string 
    //has sufficient space at the end to hold the additional characters, and that you are given the "true" length of the string. 
    //(Note:  if  implementing  in  Java,  please use a character array so that you  canperform this operation in place.) EXAMPLE Input: "Mr John  Smith JJ, 13 
    //Output: "Mr%2eJohn%2eSmith"
    public class UrlIfy
    {
        public void Url(string textToUrl)
        {
            //var str = Regex.Replace(textToUrl, @"\s", "");
            var str = textToUrl.Trim().Replace(" +", "");
            
            textToUrl = str.Replace(" ", "%2e");
        }
    }

}
