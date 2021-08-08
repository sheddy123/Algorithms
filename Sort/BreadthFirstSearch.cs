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
    }


}
