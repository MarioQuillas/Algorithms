using System.Runtime.InteropServices.ComTypes;
using Common.Interfaces;
using Graphs.Interfaces;

namespace Graphs
{
    public class VertexSearcher : IVertexSearcher
    {
        public IUndirectedGraph Graph { get; private set; }
        public INode SourceNode { get; private set; }

        public VertexSearcher(IUndirectedGraph graph, INode sourceNode)
        {
            this.Graph = graph;
            this.SourceNode = sourceNode;
        }

        public bool IsConnectedToSource(INode vertex)
        {
            return false;
        }

        public int TotalConnectedVertices()
        {
            return 0;
        }
    }
}