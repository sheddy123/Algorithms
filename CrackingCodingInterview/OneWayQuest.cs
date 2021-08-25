using System;
using System.Collections.Generic;

namespace CrackingCodingInterview
{
    public class OneWayQuest
    {
        //One Away:  There are  three types  of edits  that can  be performed  on strings: insert a  character, 
        //remove a character, or replace a character.Given  two strings, write a function to check if  they are
        //one edit (or zero edits) away.
        //EXAMPLE
        //pale, ple =>  true 
        //pales, pale  =>  true 
        //pale, bale  =>  true 
        //pale, bae  =>  false

        public bool OneAway(string keyString, string valueString)
        {
            bool check = false;
            if (valueString.Length + 1 == keyString.Length)
                check = ValueOmmitted(keyString, valueString);
            else if (valueString.Length == keyString.Length)
                check = ValueReplaced(key: keyString, value: valueString);
            return check;
        }
        public bool ValueReplaced(string key, string value)
        {
            int i = key.Length-1;
            int j = value.Length-1;
            int count = 0;
            while (i >= 0)
            {
                if (key[(i)] != value[(j)])
                    count++;
                i--; j--;
            }
            return (count == 1 || count == 0) ? true : false;
        }
        public bool ValueOmmitted(string key, string value)
        {
            int i = key.Length-1;
            int j = value.Length-1;
            int count = 0;
            for(int k =0;  k<key.Length; k++)
            {
                for(int c = 0; c<value.Length; c++)
                {
                    if(key[k] == value[c])
                    {
                        break;
                    }
                    if (c + 1 == key.Length-1)
                        count++;
                }
            }
            
            
            return (count == 1) ? true : false;
        }
    }
   
}
