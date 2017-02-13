using System;

namespace Common.Interfaces
{
    public interface INode : IEquatable<INode>
    {
        string Id { get; }
    }
}
