using System;
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

        //Write a function, hasPath, that takes in an bject representing the adjacency list
        //of a directed acyclic graph and atwo nodes (src, dst). The function should return boolean
        //indicating whether or not there exists a dircted path between the source and destination nodes.

        public bool HasPath(Dictionary<string, string[]> graphNodes, string src, string dst)
        {
            if (src == dst) return true;

            Stack<string> stackNodes = new Stack<string>(new string[] { src });

            while (graphNodes.Count > 0)
            {
                var current = stackNodes.Pop();
            
                foreach (var node in graphNodes[current])
                {
                    if (node == dst)
                        return true;
                    stackNodes.Push(node);
                }
            }

            return false;
        }

    }


}

