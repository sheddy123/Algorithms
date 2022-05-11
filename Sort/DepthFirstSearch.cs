using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public int[] DepthFirstTraversal(IDictionary<int, List<int>> tree)
        {
            List<int> resultingDfs = new List<int>();
            //Declare an object which tracks nodes that has been traversed before
            HashSet<int> trackingObject = new HashSet<int>();

            //DFS makes use of a Stack data structure
            Stack<int> nodes = new Stack<int>();
            //Add the starting node been used for traversal
            nodes.Push(tree.ElementAt(0).Key);

            //loop through the tree while it is not empty
            while(nodes.Count > 0)
            {
                //pop out element from stack
                int element = nodes.Pop();

                //check if the tracking object has contains the node, which implies that the node has been traversed
                if (!trackingObject.Contains(element))
                    trackingObject.Add(element);
                else
                    continue;

                //Add the nodes traversed which serves as the output at the end of the day
                Console.WriteLine($"{element} => ");
                resultingDfs.Add(element);

                //check if the key is contained in tree in order to get it's neighbors else we assume it is null
                bool keyIsContainedInTree = (tree.TryGetValue(element, out List<int> value));
                if (!keyIsContainedInTree)
                    continue;

                foreach(var neighbor in tree[element])
                {
                    nodes.Push(neighbor);
                }
            }

            return resultingDfs.ToArray();
        }

        public IDictionary<string, Queue<string>> UndirectedGraph(List<string[]> tree)
        {
            IDictionary<string, Queue<string>> newGraph = new Dictionary<string, Queue<string>>();
            foreach(var node in tree)
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
        /*
         * Write a function, largestComponent, that takes in the adjacency list of an undirected graph.
         * The function should return the size of the largest connected component in the graph
         */
        public int LargestComponent(IDictionary<int, List<int>> tree)
        {
            //Implement DFS
            //IDictionary<int, string> nodes = new Dictionary<int, string>();
            Stack<int> nodes = new Stack<int>();
            HashSet<int> trackVisitedNodes = new HashSet<int>();
            nodes.Push(tree.ElementAt(0).Key);

            int largestComponent = int.MinValue;
            while(nodes.Count > 0)
            {
                var currentElement = nodes.Pop();

                if (!trackVisitedNodes.Contains(currentElement))
                    trackVisitedNodes.Add(currentElement);
                else
                    continue;

                bool nodeContainsNeighbors = tree.TryGetValue(currentElement, out List<int> obj);
                
                if (!nodeContainsNeighbors)
                    continue;
                
                int currentSize = 1;
                foreach (var neighbour in tree[currentElement])
                {
                    currentSize++;
                    nodes.Push(neighbour);
                }
            
                largestComponent = Math.Max(largestComponent, currentSize);
            }

            return largestComponent;
        }
    }


}

