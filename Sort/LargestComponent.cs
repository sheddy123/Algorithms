using System.Collections.Generic;

namespace Sorting
{
    public class LargestComponent
    {
        public int largestCompo(Dictionary<string, string> graph)
        {
            int longest = 0;
            HashSet<string> visited = new HashSet<string>();
            foreach(var node in graph)
            {
                int size = ExploreSize(graph, node.Key, visited);
                if (size > longest)
                    longest = size;
            }
            return longest;
        }

        public int ExploreSize(Dictionary<string, string> exploreGraph, string node, HashSet<string> visited)
        {
            if (visited.Contains(node))
                return 0;

            visited.Add(node);
            int size = 1;
            foreach(var neighbour in exploreGraph)
            {
               size += ExploreSize(exploreGraph, neighbour.Key, visited);
            }

            return size;
        }
    }


}
