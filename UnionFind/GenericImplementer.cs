using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.Interfaces;
using UnionFind.Interfaces;

namespace UnionFind
{
    public abstract class GenericImplementer : IUnionFindImplementer
    {
        protected int totalComponents;
        protected Dictionary<INode, INode> ids;

        protected GenericImplementer(IReadOnlyCollection<INode> initialNodes)
        {
            this.totalComponents = initialNodes.Count;
            this.ids = new Dictionary<INode, INode>();
            foreach (var node in initialNodes)
            {
                this.ids.Add(node, node);
            }
        }

        public abstract void Union(INode node1, INode node2);

        public abstract INode Find(INode node);

        public bool Connected(INode node1, INode node2)
        {
            return this.Find(node1) == this.Find(node2);
        }

        public int TotalComponents() => this.totalComponents;
    }
}