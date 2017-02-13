using System.Collections.Generic;
using Common.Interfaces;

namespace UnionFind
{
    public class QuickFindImplementer : GenericImplementer
    {
        public QuickFindImplementer(IReadOnlyCollection<INode> initialNodes) : base(initialNodes)
        {
        }

        public override void Union(INode node1, INode node2)
        {
            INode n1 = this.ids[node1];
            INode n2 = this.ids[node2];

            if (n1 == n2) return;

            foreach (var node in this.ids.Keys)
            {
                if (node == n1) ids[node] = n2;
            }

            this.totalComponents -= 1;
        }

        public override INode Find(INode node) => this.ids[node];
    }
}