using System;
using System.Collections.Generic;

namespace Sorting
{
    //uses Queue
    public class BreadthFirstSearch
    {
        public void BFS(Dictionary<string, string[]> graphNodes, string startingNode)
        {
            Queue<string> queueNodes = new Queue<string>(new string[] { startingNode });
            while (queueNodes.Count > 0)
            {
                var currentNode = queueNodes.Dequeue();
                Console.WriteLine(currentNode);

                foreach (var neighbour in graphNodes[currentNode])
                {
                    queueNodes.Enqueue(neighbour);
                }
            }
        }
        //Write a function, hasPath, that takes in an bject representing the adjacency list
        //of a directed acyclic graph and atwo nodes (src, dst). The function should return boolean
        //indicating whether or not there exists a dircted path between the source and destination nodes.

        public bool HasPath(Dictionary<string, string[]> graphNodes, string src, string dst)
        {
            Queue<string> queueNode = new Queue<string>(new string[] { src });

            while(queueNode.Count > 0)
            {
                var current = queueNode.Dequeue();
                foreach(var node in graphNodes[current])
                {
                    if (node == dst)
                        return true;
                    queueNode.Enqueue(node);
                }
            }
            return false;
        }
        public Dictionary<string, HashSet<string>> ConvertToDirect()
        {
            var edges = new Dictionary<string, HashSet<string>>();
            var testCase = new List<KeyValuePair<string, string>>();
            testCase.Add(new KeyValuePair<string, string>("i","j"));
            testCase.Add(new KeyValuePair<string, string>("k","i"));
            testCase.Add(new KeyValuePair<string, string>("m","k"));
            testCase.Add(new KeyValuePair<string, string>("k","l"));
            testCase.Add(new KeyValuePair<string, string>("o","n"));
         
            foreach(var k in testCase)
            {
                if (!edges.ContainsKey(k.Key))
                {
                    HashSet<string> lst = new HashSet<string>();
                    lst.Add(k.Value);
                    edges.Add(k.Key, lst);
                }
                else if (edges.ContainsKey(k.Key))
                {
                    HashSet<string> lst = edges[k.Key];
                    lst.Add(k.Value);
                    edges[k.Key] = lst;
                }
                
                if (!edges.ContainsKey(k.Value))
                {
                    HashSet<string> lst = new HashSet<string>();
                    lst.Add(k.Key);
                    edges.Add(k.Value, lst);
                }
                else if (edges.ContainsKey(k.Value))
                {
                    HashSet<string> lst = edges[k.Value];
                    lst.Add(k.Key);
                    edges[k.Value] = lst;
                }
            }

            return edges;
            
        }
    }


}
