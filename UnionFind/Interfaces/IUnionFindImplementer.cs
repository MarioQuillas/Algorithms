using Common.Interfaces;

namespace UnionFind.Interfaces
{
    public interface IUnionFindImplementer
    {
        void Union(INode node1, INode node2);
        INode Find(INode node);
        bool Connected(INode node1, INode node2);
        int TotalComponents();
    }
}