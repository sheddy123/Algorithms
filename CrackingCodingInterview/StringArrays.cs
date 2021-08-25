using System;
using System.Collections.Generic;

namespace CrackingCodingInterview
{

    public class StringArrays
    {

        public bool IsUnique(string stringToTest)
        {
            HashSet<char> stringSet = new HashSet<char>(stringToTest.ToCharArray());
            if (stringToTest.Length == stringSet.Count)
                return true;
            return false;

        }

    }
}