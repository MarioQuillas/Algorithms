using System.Collections.Generic;
using Common.Interfaces;

namespace Graphs.Interfaces
{
    public interface IUndirectedGraph
    {
        int TotalEdges { get; }
        int TotalVertices { get; }
        void AddEdge(INode node1, INode node2);
        IEnumerable<INode> AdjacencyToNode(INode node);
    }
}