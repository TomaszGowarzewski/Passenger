using System;

namespace Passenger.Core.Domain
{
    public class Route
    {
        public Guid Id { get; protected set; }

        public Node StartNode { get; protected set; }

        public Node EndNode { get; protected set; }

        public Route(Node StartNode, Node EndNode)
        {
            Id = Guid.NewGuid();
            this.StartNode = StartNode;
            this.EndNode = EndNode;
        }

        protected Route()
        {

        }
    }
}