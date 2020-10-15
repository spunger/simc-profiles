using System.Collections.Generic;

namespace CovenantProfileGenerator.Soulbinds
{
    internal class Pathfinder
    {

        // No. of vertices in graph 
        private readonly int vertices;

        // adjacency list 
        private List<int>[] adjList;

        internal Pathfinder(int vertices)
        {

            // initialise vertex count 
            this.vertices = vertices;

            // initialise adjacency list 
            InitAdjList();
        }

        private void InitAdjList()
        {
            adjList = new List<int>[vertices];

            for (int i = 0; i < vertices; i++)
            {
                adjList[i] = new List<int>();
            }
        }

        internal void AddEdge(int begin, int end)
        {
            adjList[begin].Add(end);
        }

        internal List<List<int>> FindAllPaths(int begin, int end)
        {
            bool[] isVisited = new bool[vertices];
            var pathList = new List<int>
            {
                begin
            };

            var result = new List<List<int>>();
            // Call recursive utility 
            FindAllPathsUtil(begin, end, isVisited, pathList, result);
            
            return result;
        }
 
        private void FindAllPathsUtil(int begin, int end,
                                       bool[] isVisited,
                                       List<int> localPathList,
                                       List<List<int>> result)
        {

            if (begin.Equals(end))
            {
                result.Add(new List<int>(localPathList));
                // if match found then no need 
                // to traverse more till depth 
                return;
            }

            // Mark the current node 
            isVisited[begin] = true;

            // Recur for all the vertices 
            // adjacent to current vertex 
            foreach (int i in adjList[begin])
            {
                if (!isVisited[i])
                {
                    // store current node 
                    // in path[] 
                    localPathList.Add(i);
                    FindAllPathsUtil(i, end, isVisited,
                                      localPathList,
                                      result);

                    // remove current node 
                    // in path[] 
                    localPathList.Remove(i);
                }
            }

            // Mark the current node 
            isVisited[begin] = false;
        }
    }
}
