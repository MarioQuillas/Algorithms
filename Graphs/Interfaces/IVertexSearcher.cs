using Common.Interfaces;

namespace Graphs.Interfaces
{
    public interface IVertexSearcher
    {
        IUndirectedGraph Graph { get; }
        INode SourceNode { get; }
        bool IsConnectedToSource(INode vertex);
        int TotalConnectedVertices();
    }
}