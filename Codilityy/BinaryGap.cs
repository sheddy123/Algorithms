using System;
using System.Collections.Generic;
using System.Linq;

namespace Codilityy
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string binaryNumber = Convert.ToString(N, 2);
            List<int> highestNumber = new List<int>();
            int track = 0;
            while (track < binaryNumber.Length)
            {
                int binaryGap = binaryNumber.IndexOf("1", binaryNumber.IndexOf("1", binaryNumber.IndexOf("1")) + 1);
                var secondGap = binaryNumber.Substring(binaryGap).IndexOf("1", binaryNumber.IndexOf("1", binaryNumber.IndexOf("1") + 1) + 1);
                if (binaryGap > 1)
                {
                    highestNumber.Add((binaryGap - 1));
                    binaryNumber = binaryNumber.Substring(binaryGap);
                    //track = binaryGap;

                }
                else if (secondGap > 1)
                {
                    highestNumber.Add((secondGap - 1));
                    binaryNumber = binaryNumber.Substring(secondGap);
                }
                else
                {
                    break;
                }
            }
            if (highestNumber.Count() > 0)
            {
                return highestNumber.Max();
            }
            //If N does not contain a binary gap.
            return 0;
        }
    }

    }
