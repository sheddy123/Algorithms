﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    //Uses Stack
    public class DepthFirstSearch
    {
        public void DFS(Dictionary<string, string[]> graphValues, string startingNode)
        {
            Stack<string> tempGraph = new Stack<string>(new string[] { startingNode });
            
            while(tempGraph.Count > 0)
            {
                var currentNode = tempGraph.Pop();
                Console.WriteLine(currentNode);

                foreach(var item in graphValues[currentNode])
                {
                    tempGraph.Push(item);
                }
            }
        }
    }


}