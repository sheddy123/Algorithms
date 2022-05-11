using System;
using System.Collections.Generic;
using System.Linq;

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
        public IDictionary<string, Queue<string>> UndirectedGraph(List<string[]> tree)
        {
            IDictionary<string, Queue<string>> newGraph = new Dictionary<string, Queue<string>>();
            foreach (var node in tree)
            {
                var firstNode = node[0];
                var secondNode = node[1];

                if (!newGraph.ContainsKey(firstNode))
                    newGraph[firstNode] = new Queue<string>();

                if (!newGraph.ContainsKey(secondNode))
                    newGraph[secondNode] = new Queue<string>();

                newGraph[firstNode].Enqueue(secondNode);
                newGraph[secondNode].Enqueue(firstNode);
            }
            return newGraph;
        }

        public int GetShortestPath(IDictionary<string, Queue<string>> tree)
        {
            Queue<string> nodes = new Queue<string>();
            HashSet<string> trackNodeNeighbors = new HashSet<string>();
           
            nodes.Enqueue("w");

            int shortestPathCount = int.MaxValue;
            while(nodes.Count > 0)
            {
                var currentElement = nodes.Dequeue();
                
                if (!trackNodeNeighbors.Contains(currentElement))
                    trackNodeNeighbors.Add(currentElement);
                else
                    continue;

                bool nodeContainsNeighbors = tree.TryGetValue(currentElement, out Queue<string> obj);
                
                if (!nodeContainsNeighbors)
                    continue;
                
                int shortestPathCurrentCount = 1;
                foreach(var neighbor in tree[currentElement])
                {
                    shortestPathCurrentCount++;
                    nodes.Enqueue(neighbor);
                }
                shortestPathCount = Math.Min(shortestPathCount, shortestPathCurrentCount);
            }
            return shortestPathCount;
        }
        //Solution 2
        public int[] BreadthFirstSearchTraversal(IDictionary<int, List<int>> tree)
        {
            List<int> resultingTree = new List<int>();
            //Breadth first search uses the data structure [Queue]
            //Initialize a new queue object and then enqueue the first item in the dictionary
            Queue<int> nodes = new Queue<int>();
            nodes.Enqueue(tree.ElementAt(0).Key);

            //Initialize a tracking mechanism which prevents duplicate traversal of node
            HashSet<int> nodeStore = new HashSet<int>();

            //iterate through a loop and ensure that the queue contains element
            while(nodes.Count > 0)
            {
                //Get the current element of the queue in order to traverse it's neighbors as well
                int currentElement = nodes.Dequeue();
                if (!nodeStore.Contains(currentElement))
                    nodeStore.Add(currentElement);
                else
                    continue;
                Console.WriteLine($"{currentElement} =>");
                resultingTree.Add(currentElement);

                var isKeyPresent = tree.TryGetValue(currentElement, out List<int> output);
                if (!isKeyPresent)
                    continue;

                //iterate through the current elements neighbors and then add them to the queue
                foreach(var neighbor in tree[currentElement])
                {
                    nodes.Enqueue(neighbor);
                }
            }

            return resultingTree.ToArray();
        }
    }


}
