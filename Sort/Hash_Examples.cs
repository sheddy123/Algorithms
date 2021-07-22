using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class Hash_Examples
    {
        public HashSet<string> PhoneNumbers()
        {
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>() {
                { "A", "090757383" },
                { "B","090909949"},
                { "C", "090757383" },
                { "D","090909949"},
                { "E", "090757383" },
                { "F","090909949"},
                { "G", "090757383" },
                { "H","0909099439"},
                { "I", "0907575383" },
                { "J","09090998439"},
                { "K", "0907576383" },
                { "L","09090995449"},
                { "M", "0907572383" },
                { "N","09090991549"},
                { "O", "0907572383" },
                { "P","0909091949"},
                { "Q", "0907517383" },
                { "R","09090964949"},
                { "S", "0907576383" },
                { "T", "0907573383" },
                { "U","0909099231"},
                { "V","0909096729"},
                { "W","0909074249"},
                { "X","0909094569"},
                { "Y","0909091449"},
                { "Z","0909099239"},
            };

            HashSet<string> hashSet1 = new HashSet<string>(phoneNumbers.Values);

            return hashSet1;
        }
    }
}
