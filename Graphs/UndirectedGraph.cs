using System.Collections.Generic;
using Common.Interfaces;
using Graphs.Interfaces;

namespace Graphs
{
    public class UndirectedGraph : IUndirectedGraph
    {
        public int TotalEdges { get; private set; }

        public int TotalVertices { get; private set; }

        /// <summary>
        /// This is the array of adjency list.
        /// <remarks>
        /// We need to take in to account that the adjacency list can be different for the same graphs.
        /// This is because the input order of edges is taken into while reading the graph from a streaming input.
        /// 
        /// On the other hand, this shouldn't be a problem since the interface IEnumerable doesn't really know about an order of iteration and the algorithms won't depend on that. 
        /// 
        /// Apparently there are other ways to implement this (like creatin a Edge class) but this is the best one for the current algorithms.
        /// </remarks>
        /// </summary>
        private Dictionary<INode, ICollection<INode>>  adjacency;

        public UndirectedGraph(int totalVertices)
        {
            this.TotalVertices = totalVertices;
            this.TotalEdges = 0;
            this.adjacency = new Dictionary<INode, ICollection<INode>>();
        }

        public void AddEdge(INode node1, INode node2)
        {
            this.adjacency[node1].Add(node2);
            this.adjacency[node2].Add(node1);
            this.TotalEdges += 1;
        }

        public IEnumerable<INode> AdjacencyToNode(INode node)
        {
            return this.adjacency[node];
        }
    }
}
