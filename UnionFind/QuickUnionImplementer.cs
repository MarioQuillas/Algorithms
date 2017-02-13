using System.Collections.Generic;
using Common.Interfaces;

namespace UnionFind
{
    public class QuickUnionImplementer : GenericImplementer
    {
        public QuickUnionImplementer(IReadOnlyCollection<INode> initialNodes) : base(initialNodes)
        {
        }

        public override void Union(INode node1, INode node2)
        {
            throw new System.NotImplementedException();
        }

        public override INode Find(INode node)
        {
            throw new System.NotImplementedException();
        }
    }
}