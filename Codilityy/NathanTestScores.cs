﻿using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
namespace Codilityy
{
    public class NathanTestScores
    {
       public Dictionary<string, int> groups = new Dictionary<string, int>();
       public Dictionary<string, int> scoresPassed = new Dictionary<string, int>();

        public int solution(string[] T, string[] R)
        {
            Get(T, R);
            var totalNumberOfGroups = groups.Values.Count;
            var totalNumberOfScores = scoresPassed.Where(k => k.Value!=-1).ToDictionary(j=> j.Value);
            var totalPoints = ((totalNumberOfScores.Count * 100)/totalNumberOfGroups);
            return totalPoints;

        }
        public void Get(string[] T, string[] R)
        {
            string temp = T[0];
            int j = 0;
            for (int i = 0; i < T.Length; i++)
            {
                string result1 = System.Text.RegularExpressions.Regex.Match(T[i], @"\d+").Value;
                var index = T[i].IndexOf(result1);
                var testCaseName = T[i].Substring(0, index + 1);

                if (!groups.ContainsKey(testCaseName))
                {
                    groups.Add(testCaseName, i);//Number of groups
                    
                }

                if (!scoresPassed.ContainsKey(testCaseName) && R[i] == "OK")
                {
                    scoresPassed.Add(testCaseName, j++);//Number of groups passed
                }
                if (!scoresPassed.ContainsKey(testCaseName) && R[i] != "OK")
                {
                    scoresPassed.Add(testCaseName, -1);
                    //scoresPassed.Remove(testCaseName);
                }
                if (scoresPassed.ContainsKey(testCaseName) && R[i] != "OK")
                {
                    scoresPassed[testCaseName] = -1;
                    //scoresPassed.Add(testCaseName, -1);
                    //scoresPassed.Remove(testCaseName);
                }


            }

        }
    }

}