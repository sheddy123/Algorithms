using System.Linq;
using System;
using System.Collections.Generic;


namespace Codilityy
{
    public class TravelAgency
    {
        public int solution(int[] A)
        {
            HashSet<int> distinctValues = new HashSet<int>(A);
            int[] locations = distinctValues.ToArray();
            int shortestVacation = A.Length;
            //   foreach(var item in locations){
            //       Console.WriteLine(item);
            //   }
            for (int i = 0; i < A.Length; i++)
            {
                int distance = 0;
                List<int> myLocation = new List<int>(locations);

                for (int k = i; k < A.Length; k++)
                {
                    distance++;
                    //Console.WriteLine(distance);
                    if (myLocation.Contains(A[k]))
                    {
                        myLocation.Remove(A[k]);
                    }
                    if (myLocation.Count == 0)
                    {
                        break;
                    }
                }
                if (distance <= shortestVacation && myLocation.Count == 0)
                {
                    shortestVacation = distance;
                }
            }
            return shortestVacation;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }

        public int ShortestDistance(int[] A)
        {
            int i = 0; int j = i+1; int distance = 2; int shortestVacation = A.Length - 1;
            int track = 2;
            HashSet<int> locationEntry = new HashSet<int>();

            while(i < j)
            {
                if (j == A.Length - 1)
                {
                    shortestVacation = Math.Min(shortestVacation, distance);
                    i++; j = i+1;
                    track = 2;
                    locationEntry = new HashSet<int>();
                }

                if (i == A.Length - 4)
                    break;


                
                if (A[i] == A[j] && !locationEntry.Contains(A[i]))
                {
                    locationEntry.Add(A[i]);
                    distance = track;
                    //distance++;
                }
                if (A[i] != A[j] && !locationEntry.Contains(A[j]))
                {
                    if (!locationEntry.Contains(A[i]))
                    {
                        locationEntry.Add(A[i]);
                        distance = track;
                    }
                    locationEntry.Add(A[j]);
                    distance = track;
                    //distance++;
                }
                j++;
                track++;
            }
            return shortestVacation;
        }
    }

}
